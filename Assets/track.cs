using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject container;
    public GameObject prefab;
    
    GameObject tracks;
    Vector3 newpoint=new Vector3(0,0,0);

    void Start()
    {
        generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generate(){
        if(container == null){
            container = new GameObject("Container");
            container.transform.parent = transform;
            newpoint = new Vector3(0,0,0);
        }
        tracks = Instantiate(prefab,newpoint,Quaternion.identity);
        newpoint = newpoint + new Vector3(30,0,-52);
        tracks.transform.parent = container.transform;
        
    }

}
