using UnityEngine;


public class ScaleSpehere : MonoBehaviour
{
    public GameObject object_radius;
    public float r;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        r = object_radius.GetComponent<SphereProperty>().radius;
        transform.localScale = new Vector3(0.2f * r, 0.2f * r, 0.2f * r);
    }
}

