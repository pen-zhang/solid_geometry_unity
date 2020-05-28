using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeFreeFalling : MonoBehaviour
{
    public GameObject plane;
    public GameObject fallingObject;
    public GameObject panel;
    public float gravity;
    public float speed;
    Vector3 sp;
    bool mark = true;

    // Start is called before the first frame update
    void Start()
    {
        sp = fallingObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GetComponent<Toggle>().isOn==true)
        {
            
            fallingObject.GetComponent<ScaleCube>().enabled = false;
            
            panel.SetActive(true);
            
            if (mark==true)
            {
                Debug.Log("ok");
                GameObject.FindGameObjectWithTag("Timer").GetComponent<TextMeshProUGUI>().text = "Time: 0";
                StartCoroutine(Fall());
                mark = false;
            }

        }
        else
        {
            fallingObject.GetComponent<Rigidbody>().isKinematic = true;
            mark = true;
            fallingObject.transform.position = sp;
            fallingObject.GetComponent<ScaleCube>().enabled = true;
            plane.SetActive(false);
            panel.SetActive(false);
            //fallingObject.GetComponent<Rigidbody>().useGravity = false;
            //fallingObject.GetComponent<Collider>().isTrigger = false;
        }
    }
    
    IEnumerator Fall()
    {
        fallingObject.GetComponent<DetectCollision>().time = 0;
        plane.SetActive(true);
        fallingObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        fallingObject.transform.position = new Vector3(sp.x, sp.y + 0.3f, sp.z);
        fallingObject.transform.rotation =new Quaternion(0, 0, 0,1);
        yield return new WaitForSeconds(1);
        fallingObject.GetComponent<Rigidbody>().isKinematic = false;
        //fallingObject.GetComponent<Collider>().isTrigger = true;
        //fallingObject.GetComponent<Rigidbody>().useGravity = true;
        gravity =- float.Parse(GameObject.FindGameObjectWithTag("Gravity").GetComponent<InputField>().text);
        Physics.gravity = new Vector3(0,gravity, 0);
        fallingObject.GetComponent<Rigidbody>().mass = float.Parse(GameObject.FindGameObjectWithTag("Mass").GetComponent<InputField>().text);
        
    }

    public void PlayAgain()
    {

        mark = true;
        fallingObject.GetComponent<DetectCollision>().time = 0;
        plane.SetActive(true);
        fallingObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        fallingObject.transform.position = new Vector3(sp.x, sp.y + 0.3f, sp.z);
        fallingObject.transform.rotation = new Quaternion(0, 0, 0, 1);
    }
    
}
