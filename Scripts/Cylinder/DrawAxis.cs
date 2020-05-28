using UnityEngine;

public class DrawAxis : MonoBehaviour
{
    public LineRenderer lr;
   
    public GameObject vertex1;
    public GameObject vertex2;
    public GameObject vertex3;
    public GameObject vertex4;


    // Start is called before the first frame update
    void Start()
    {
        lr.startWidth = 0.005f;
        lr.positionCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, new Vector3(vertex1.transform.position.x, vertex1.transform.position.y, vertex1.transform.position.z));
        lr.SetPosition(1, new Vector3(vertex2.transform.position.x, vertex2.transform.position.y, vertex2.transform.position.z));
        lr.SetPosition(2, new Vector3(vertex3.transform.position.x, vertex3.transform.position.y, vertex3.transform.position.z));
        lr.SetPosition(3, new Vector3(vertex4.transform.position.x, vertex4.transform.position.y, vertex4.transform.position.z));
        lr.SetPosition(4, new Vector3(vertex1.transform.position.x, vertex1.transform.position.y, vertex1.transform.position.z));
    }
}
