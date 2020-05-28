using UnityEngine;

public class ScaleCube : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(GetComponent<CubeProperty>().a / 10, GetComponent<CubeProperty>().b / 10,
            GetComponent<CubeProperty>().c / 10);

    }
}
