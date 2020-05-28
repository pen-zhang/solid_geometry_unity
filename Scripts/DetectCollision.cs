using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isCollided = false;
    public float time;
    void Start()
    {
        //GetComponent<Collider>().isTrigger = false;
        //GetComponent<Rigidbody>().useGravity = false; 

        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody>().isKinematic == false )
        {
            time += Time.deltaTime;            
            
            GameObject.FindGameObjectWithTag("Timer").GetComponent<TextMeshProUGUI>().text = "Time: " + System.Math.Round(time, 2);
            GameObject.FindGameObjectWithTag("Speed").GetComponent<TextMeshProUGUI>().text="Speed: "+System.Math.Round(GetComponent<Rigidbody>().velocity.magnitude,2);
        }

    }

    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
           
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    */
    private void OnCollisionEnter(Collision collision)
    {

            //GetComponent<Collider>().isTrigger = false;
            //GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;

    }



}
