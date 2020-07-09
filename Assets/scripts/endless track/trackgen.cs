using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackgen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject trackprefab;
    public int batchsize = 5;
    // int count = 0;


    GameObject[] tracks;
    Vector3 newpoint=new Vector3(0,0,0);

    void Start()
    {
        tracks  = new GameObject[batchsize];
        GenTrack();
        Debug.Log("*********");
    }
    void GenTrack(){
        for (int i = 0;i<batchsize;i++){
            tracks[i] = Instantiate(trackprefab,newpoint,Quaternion.identity);
            newpoint = newpoint + new Vector3(0,0,7.35f);
        }
    }
    public void regentrack(){
        for (int i = 0;i<batchsize;i++){
            tracks[i].transform.position = newpoint;
            newpoint = newpoint + new Vector3(0,0,7.35f);
        }
    }



}
