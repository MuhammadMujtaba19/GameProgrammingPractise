using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running : MonoBehaviour
{
    Animator anim;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        flag = Input.GetKey("up");
    }
    private void FixedUpdate() {
        if(flag){
            anim.SetBool("runn",flag);
        }

    }
}
