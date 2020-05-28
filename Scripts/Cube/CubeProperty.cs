using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeProperty : MonoBehaviour
{
    public float a = 1.0f;
    public float b = 1.0f;
    public float c = 1.0f;
    public Slider sliderA;
    public Slider sliderB;
    public Slider sliderC;
    public GameObject edgeA;
    public GameObject edgeB;
    public GameObject edgeC;
    public GameObject surfaceArea;
    public GameObject volume;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        edgeA.GetComponent<TextMeshProUGUI>().text = "Edge:a=" + a;
        edgeB.GetComponent<TextMeshProUGUI>().text = "Edge:b=" + b;
        edgeC.GetComponent<TextMeshProUGUI>().text = "Edge:c=" + c;
        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=2(ab+ac+bc)=" +
            System.Math.Round(2 * (a * b + a * c + b * c), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : V=abc=" +
            System.Math.Round(a * b * c, 2);
    }

    public void ChangeText()
    {
        a = sliderA.value / 12;
        b = sliderB.value / 12;
        c = sliderC.value / 12;

        int i = (int)(a * 100);
        a = (float)(i * 1.0) / 100;
        i = (int)(b * 100);
        b = (float)(i * 1.0) / 100;
        i = (int)(c * 100);
        c = (float)(i * 1.0) / 100;
        edgeA.GetComponent<TextMeshProUGUI>().text = "Edge:a=" + a;
        edgeB.GetComponent<TextMeshProUGUI>().text = "Edge:b=" + b;
        edgeC.GetComponent<TextMeshProUGUI>().text = "Edge:c=" + c;
        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=2(ab+ac+bc)=" +
            System.Math.Round(2 * (a * b + a * c + b * c), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : V=abc=" +
            System.Math.Round(a * b * c, 2);
    }
}
