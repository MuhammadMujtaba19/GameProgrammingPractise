using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour
{
    
    public GameObject track;
    trackgen trackController; 
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,10);
        trackController=track.GetComponent<trackgen>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name=="wall"){
            count+=1;

            if(count==trackController.batchsize){
                trackController.regentrack();
                count = 0;

            }

        }
    }
}
