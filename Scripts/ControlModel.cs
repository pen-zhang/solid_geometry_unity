using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControlModel : MonoBehaviour
{

    [Range(0f, 1f)]
    public float transparent = 0.5f;
    public Canvas cv;
    private Vector3 startPosition;
    private List<RaycastResult> r;
    bool touchSlider = false;


    // Start is called before the first frame update
    void Start()
    {
        cv = FindObjectOfType<Canvas>();

        Renderer r = gameObject.GetComponent<Renderer>();
        Color materialColor = r.material.color;
        r.material.color = new Color(materialColor.r, materialColor.g, materialColor.b, transparent);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
            r = cv.GetComponent<MouseOnSlider>().CheckMouseClick();

            if (r != null)
                foreach (RaycastResult ob in r)
                {
                    if (ob.gameObject.name == "Handle")
                    {
                        touchSlider = false;
                        return;
                    }
                }
            touchSlider = true;
            //Debug.Log(mark);
        }
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("start" + startPosition);

            //Debug.Log("end" + Input.mousePosition);

            Vector3 mouseDelta = Input.mousePosition - startPosition;
            //Debug.Log("Delta" + mouseDelta);
            if (mouseDelta.sqrMagnitude < 0.1f)
            {
                return; // don't do tiny rotations.
            }
            if (touchSlider == true)
            {
                transform.eulerAngles = new Vector3(mouseDelta.y, -mouseDelta.x, mouseDelta.z);
            }
        }
    }



}
