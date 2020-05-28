using UnityEngine;

public class DrawBase : MonoBehaviour
{
    
    public int segments;
    public float xradius;
    public float yradius;
    LineRenderer line;
    public GameObject drawOnObject ;
    
    void Start()
    {
        segments = 30;
        line = gameObject.GetComponent<LineRenderer>();
        line.startWidth = 0.002f;
        line.useWorldSpace = false;
        line.positionCount = segments+1;
        CreatePoints();
        
    }
    void Update()
    {
        CreatePoints();
    }

    void CreatePoints()
    {
        xradius = GetComponent<SphereCollider>().radius;
        yradius = GetComponent<SphereCollider>().radius;
        
        var positions=new Vector3[segments+1];
        float x;
        float y;

        float angle = 20f;

        for (int i = 0; i < (segments+1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * xradius;
            y = Mathf.Cos(Mathf.Deg2Rad * angle) * yradius;
            
            positions[i] = new Vector3(x, y, drawOnObject.transform.position.z);          

            angle += (360f / segments);
        }
        line.SetPositions(positions);
    }
}
