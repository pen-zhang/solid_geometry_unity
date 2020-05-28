using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeComplete : MonoBehaviour
{
    public bool played = false;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(played)
        {
            played = false;
            Debug.Log(Time.time);
            gameObject.SetActive(false);
            cube.SetActive(true);
            cube.transform.rotation = gameObject.transform.rotation;
            
        }
       
    }
}
