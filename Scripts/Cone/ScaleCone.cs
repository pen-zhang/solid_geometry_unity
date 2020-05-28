using UnityEngine;

public class ScaleCone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(GetComponent<ConeProperty>().r / 5, GetComponent<ConeProperty>().r / 5,
            GetComponent<ConeProperty>().h / 5);

    }
}
