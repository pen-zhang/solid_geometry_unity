using UnityEngine;

public class ScaleCylinder : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(GetComponent<CylinderProperty>().r / 10, GetComponent<CylinderProperty>().h / 10,
            GetComponent<CylinderProperty>().r / 10);

    }
}
