using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGenerator : MonoBehaviour
{
    GameObject tile;
    GameObject container;
    public int x;
    public int y;
    public GameObject prefabs;
    float xfactor = 0;
    float yfactor = 0;

    // Start is called before the first frame update
    void Start()
    {

        generate();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void generate(){
        container = new GameObject("Map Container");
        container.transform.parent = transform;
        for (int i = 0;i<x;i++){
            xfactor = 0 ;
            for (int j=0;j<y;j++){
                Vector3 point = new Vector3(j+xfactor,0,yfactor+i);
                GameObject temp=Instantiate(prefabs,point,Quaternion.identity);
                temp.transform.Rotate(90,0,0);
                xfactor = xfactor + 0.05f ;
                temp.transform.parent = container.transform;

            }
            yfactor = yfactor + 0.05f ;
        }
    }
}
