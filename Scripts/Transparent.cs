using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Transparent : MonoBehaviour
{

    [Range(0f, 1f)]
    public float transparent = 0.5f;



    // Start is called before the first frame update
    void Start()
    {

        Renderer r = gameObject.GetComponent<Renderer>();
        Color materialColor = r.material.color;
        r.material.color = new Color(materialColor.r, materialColor.g, materialColor.b, transparent);
    }



}
