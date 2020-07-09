using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator anim;
    bool iswalking;
    bool isturning;
    float turning=0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        iswalking = Input.GetKey("up");
        turning = Input.GetAxis("Horizontal");

    }
    private void FixedUpdate() {
        anim.SetBool("is_walking",iswalking);
        isturning = (turning!=0.0f);

        anim.SetBool("is_turning",isturning);
        anim.SetFloat("turning",turning);
        
    }
}
