using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    float firstClick, clickdelay;
    int clickcount;
    bool coroutineAllowed;
    public GameObject animeObject;
    
    // Start is called before the first frame update
    void Start()
    {
        animeObject.SetActive(false);
        firstClick =0;
        clickdelay = 0.2f;
        clickcount = 0;
        coroutineAllowed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;     
                    
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit,100.0f))
            {
                if(hit.transform.gameObject.name=="Cube")
                {
                    
                    clickcount += 1;
                    if (clickcount == 1 && coroutineAllowed)
                    {
                        firstClick = Time.time;
                        StartCoroutine(DoubleClickDetection());
                    }
                }
            }
            
        }
    }

    IEnumerator DoubleClickDetection()
    {
        coroutineAllowed = false;
        while(Time.time<firstClick+clickdelay)
        {
            if(clickcount==2)
            {
                gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                animeObject.transform.rotation = gameObject.transform.rotation;
                gameObject.SetActive(false);
                animeObject.SetActive(true);
                Debug.Log(Time.time);
                animeObject.GetComponent<Animation>().Play();
                
                break;
            }
            yield return new WaitForEndOfFrame();
        }
        clickcount = 0;
        firstClick = 0;
        coroutineAllowed = true;
    }

   
}
