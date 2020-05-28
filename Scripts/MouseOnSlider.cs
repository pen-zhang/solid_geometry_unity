using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOnSlider : MonoBehaviour
{
    GraphicRaycaster raycaster;
    // Start is called before the first frame update
    void Start()
    {
        raycaster = GetComponent<GraphicRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<RaycastResult> CheckMouseClick()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current);
        List<RaycastResult> results = new List<RaycastResult>();
        pointerData.position = Input.mousePosition;
        raycaster.Raycast(pointerData, results);
        /*
        foreach (RaycastResult result in results)
        {
            Debug.Log("Hit " + result.gameObject.name);
        }
        */
        return results;


    }
}
