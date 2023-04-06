using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.Networking;
using System.Text;

namespace Deb1{
    public static class HttpClient
    {
        public static async Task<T> Get<T>(string endpoint)
        {
            var getRequest = CreateRequest(endpoint);
            getRequest.SendWebRequest();
            while(!getRequest.isDone)await Task.Delay(10);
            return JsonUtility.FromJson<T>(getRequest.downloadHandler.text); 
        }
        public static async Task<T> Post<T>(string endpoint,object payload)
        {
            var postRequest = CreateRequest(endpoint, RequestType.POST, payload);
            postRequest.SendWebRequest();

            while (!postRequest.isDone) await Task.Delay(10);
            return JsonUtility.FromJson<T>(postRequest.downloadHandler.text);
        }
        private static UnityWebRequest CreateRequest(string path,RequestType type = RequestType.GET, object data = null)
        {
            var request = new UnityWebRequest(path, type.ToString());
            if (data != null)
            {
                var bodyRaw = Encoding.UTF8.GetBytes(JsonUtility.ToJson(data));
                request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            }
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            return request;
        }
        private static void AttchHeader(UnityWebRequest request,string key,string value)
        {
            request.SetRequestHeader(key, value);
        }
    }
    public enum RequestType{
    GET=0,
    POST=1,
    PUT=2
    }
}