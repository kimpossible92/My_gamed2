using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class PreLoaderScript : MonoBehaviour
{

 [SerializeField] public string _sceneName = "maingame";
    public string _SceneName => this._sceneName;

    private AsyncOperation _asyncOperation;

    private IEnumerator LoadSceneAsyncProcess(string sceneName)
    {
        // Begin to load the Scene you have specified.
        this._asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        // Don't let the Scene activate until you allow it to.
        this._asyncOperation.allowSceneActivation = false;

        while (!this._asyncOperation.isDone)
        {
            Debug.Log($"[scene]:{sceneName} [load progress]: {this._asyncOperation.progress}");

            yield return null;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(StartScene());

    }

   private void Update()
    {
        if (this._asyncOperation == null)
        {
            Debug.Log("Started Scene Preloading");

            // Start scene preloading.
            this.StartCoroutine(this.LoadSceneAsyncProcess(sceneName: this._sceneName));
        }

        // Press the space key to activate the Scene.
        
    }

    private IEnumerator StartScene(){
        yield return new WaitForSeconds(5);

        if (this._asyncOperation != null)
        {
            Debug.Log("Allowed Scene Activation");

            this._asyncOperation.allowSceneActivation = true;
        }
    }
}
