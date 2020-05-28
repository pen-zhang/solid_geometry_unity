using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SphereProperty : MonoBehaviour
{
    public float radius = 1.0f;
    public Slider slider;
    public GameObject diameter;
    public GameObject surfaceArea;
    public GameObject volume;
    //public bool isValueChanged=false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "Radius : r=" + radius;
        diameter.GetComponent<TextMeshProUGUI>().text = "Diameter : d=2r=" + 2 * radius;
        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=4πr<sup>2</sup>=" +
           System.Math.Round(4 * System.Math.PI * System.Math.Pow(radius, 2), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : V=4/3xπr<sup>3</sup>=" +
            System.Math.Round(4 / 3 * System.Math.PI * System.Math.Pow(radius, 3), 2);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeText()
    {
        radius = slider.value / 12;
        int i = (int)(radius * 100);
        radius = (float)(i * 1.0) / 100;
        GetComponent<TextMeshProUGUI>().text = "Radius:r=" + radius;
        diameter.GetComponent<TextMeshProUGUI>().text = "Diameter : d=2r=" + 2 * radius;
        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=4πr<sup>2</sup>=" +
            System.Math.Round(4 * System.Math.PI * System.Math.Pow(radius, 2), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : V=4/3xπr<sup>3</sup>=" +
            System.Math.Round(4 / 3 * System.Math.PI * System.Math.Pow(radius, 3), 2);
    }
}
