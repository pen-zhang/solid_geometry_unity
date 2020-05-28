using UnityEngine;

public class Cube_DrawLine : MonoBehaviour
{
    public LineRenderer lr;
    public GameObject vertex1;
    public GameObject vertex2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, new Vector3(vertex1.transform.position.x, vertex1.transform.position.y, vertex1.transform.position.z));
        lr.SetPosition(1, new Vector3(vertex2.transform.position.x, vertex2.transform.position.y, vertex2.transform.position.z));
    }
}
