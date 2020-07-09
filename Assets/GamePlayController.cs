using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlayController : MonoBehaviour
{
    // Start is called before the first frame update
    float start = 3f;
    float current = 0f;
    public Text TimerUI;
    public Text points;
    public GameObject car;
    public GameObject steering;
    
    // public TextMeshProUGUI TimerUI; 
    void Start()
    {
        current = start;
        car.SetActive(false);
        points.enabled = false;
        steering.SetActive(false);
        // changeColor();
        InvokeRepeating("changeColor", 1, 10);

    }

    // Update is called once per frame
    void Update()
    {
        current -= 1 * Time.deltaTime;
        if(current == 0){
            TimerUI.text = "Lets Go";

        }else if(current<0){
            TimerUI.enabled = false;
            car.SetActive(true);
            car.transform.parent.GetComponent<Rigidbody>().useGravity = true;
            points.enabled = true;
            steering.SetActive(true);
        }
        else{
            TimerUI.text = current.ToString("0");
            // Debug.Log(current);

        }


    }
    void changeColor(){
        // Debug.Log("color change");
        var clr = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f));
        foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("foo"))
        {
            // Debug.Log("inside for loop");
            
            fooObj.GetComponent<Renderer>().materials[1].SetColor("_Color", clr);
            fooObj.GetComponent<Renderer>().materials[0].SetColor("_Color", clr);

        }  
     
    }
}
