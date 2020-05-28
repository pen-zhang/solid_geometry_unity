using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CylinderProperty : MonoBehaviour
{
    public float r = 1.0f;
    public float h = 1.0f;
    public Slider sliderH;
    public Slider sliderR;
    public GameObject height;
    public GameObject baseradius;
    public GameObject surfaceArea;
    public GameObject volume;
    //public bool isValueChanged=false;
    // Start is called before the first frame update
    void Start()
    {
        baseradius.GetComponent<TextMeshProUGUI>().text = "Radius : r=" + r;
        height.GetComponent<TextMeshProUGUI>().text = "Height : h=" + h*3;

        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=2πr(h+r)=" +
            System.Math.Round(2 * System.Math.PI * r * (h*3 + r), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : πr<sup>2</sup>h=" +
            System.Math.Round(System.Math.PI * System.Math.Pow(r, 2) * h*3, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText()
    {
        r = sliderR.value / 12;
        int i = (int)(r * 100);
        r = (float)(i * 1.0) / 100;
        h = sliderH.value / 12;
        i = (int)(h * 100);
        h = (float)(i * 1.0) / 100;
        
        baseradius.GetComponent<TextMeshProUGUI>().text = "Radius : r=" + r;
        height.GetComponent<TextMeshProUGUI>().text = "Height : h=" + h*3;

        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=2πr(h+r)=" +
            System.Math.Round(2*System.Math.PI * r*(h*3+r), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : πr<sup>2</sup>h=" +
            System.Math.Round(System.Math.PI * System.Math.Pow(r, 2)*h*3, 2);
    }
}
