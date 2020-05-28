using UnityEngine;

public class SphereRadius : MonoBehaviour
{
    //public LineRenderer lr;
    public GameObject pointOnSurface;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 center = gameObject.GetComponentInParent<Transform>().position;
        //length = gameObject.GetComponentInParent<ScaleSpehere>().r*0.05f;
        GetComponent<LineRenderer>().SetPosition(0, center);
        GetComponent<LineRenderer>().SetPosition(1, new Vector3(pointOnSurface.transform.position.x, pointOnSurface.transform.position.y, pointOnSurface.transform.position.z));
        //lr.SetPosition(1, new Vector3(r, transform.position.y, transform.position.z));
    }
}
