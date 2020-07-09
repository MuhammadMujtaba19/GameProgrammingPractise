
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
    
public class playercontroller : MonoBehaviour {
    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have
    public float speed = -0.5f;
    int temp = 0;
    bool running = true;
    ScoreManager scoremanager; 

    private void Start() {
        scoremanager=GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    private void LateUpdate() {
        temp+=1;
        if(temp == 8){
            temp = 0;
            if (running){
                scoremanager.changeScore(1);
            }

        }
    }
    public void FixedUpdate()
    {
        
        float motor = maxMotorTorque * speed;
        float steering = maxSteeringAngle * SimpleInput.GetAxis("Horizontal");
            
        foreach (AxleInfo axleInfo in axleInfos) {
            if (axleInfo.steering) {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor) {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }
    private void OnCollisionEnter(Collision other) {
        string gname = other.gameObject.name;
        // Debug.Log(gname);
        if (gname == "Cube" || gname == "Cube (1)" || gname == "MT_Fence_IN"|| gname == "MT_Fence_OUT" ){
            running = false;
            speed = 0;
            // foreach (AxleInfo axleInfo in axleInfos) {
            //     axleInfo.leftWheel.motorTorque = 0;
            //     axleInfo.rightWheel.motorTorque = 0;
            // }
            
        }
        

    }
    private void OnTriggerEnter(Collider other) {
        string gname = other.gameObject.name;
        if (gname == "wall"){
            GameObject.Find("Track").GetComponent<track>().generate();
        }
    }
}
[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}