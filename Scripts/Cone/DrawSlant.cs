using UnityEngine;

public class DrawSlant : MonoBehaviour
{
    public LineRenderer lr;
    public GameObject point;
    public GameObject vertex1;
    public GameObject vertex2;


    // Start is called before the first frame update
    void Start()
    {
        lr.startWidth = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, new Vector3(vertex1.transform.position.x, vertex1.transform.position.y, vertex1.transform.position.z));
        lr.SetPosition(1, new Vector3(point.transform.position.x, point.transform.position.y, point.transform.position.z));
        lr.SetPosition(2, new Vector3(vertex2.transform.position.x, vertex2.transform.position.y, vertex2.transform.position.z));
    }
}
