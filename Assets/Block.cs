using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
    public HitCandy candy;
    public int row;
    public int col;
    public int types;
    public List<GameObject> block = new List<GameObject>();
    private int ccc;
    public bool emptyes=false;
    [SerializeField] Sprite GetSprite1;
    [HideInInspector] public int modelvlsquare;
    public int addScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void DestroyBlocks()
    {

    }
}
public class SquareBlocks
{
    public int blck;
    public void Changeblck(int bl) { blck = bl; }
    public int block() { return blck; }
    public int obstacle;
}
