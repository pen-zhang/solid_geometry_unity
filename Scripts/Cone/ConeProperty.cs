using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConeProperty : MonoBehaviour
{
    public float r = 1.0f;
    public float h = 3.0f;
    public Slider sliderH;
    public Slider sliderR;
    public double l;
    public GameObject slant;
    public GameObject height;
    public GameObject coneradius;
    public GameObject surfaceArea;
    public GameObject volume;
    //public bool isValueChanged=false;
    // Start is called before the first frame update
    void Start()
    {
        l = System.Math.Round(Mathf.Sqrt(Mathf.Pow(h, 2) + Mathf.Pow(r, 2)), 2);
        coneradius.GetComponent<TextMeshProUGUI>().text = "Radius : r=" + r;
        height.GetComponent<TextMeshProUGUI>().text = "Height : h=" + h;

        slant.GetComponent<TextMeshProUGUI>().text = "Slant : l=√h<sup>2</sup>+r<sup>2</sup>=" + l;
        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=πr(l+r)=" +
            System.Math.Round(System.Math.PI * r * (l + r), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : V=1/3xπr<sup>2</sup>h=" +
            System.Math.Round(1 / 3 * System.Math.PI * System.Math.Pow(r, 2) * h, 2);
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
        h = sliderH.value / 4;
        i = (int)(h * 100);
        h = (float)(i * 1.0) / 100;
        l =System.Math.Round( Mathf.Sqrt(Mathf.Pow(h, 2) + Mathf.Pow(r, 2)),2);
        
        coneradius.GetComponent<TextMeshProUGUI>().text = "Radius : r=" + r;
        height.GetComponent<TextMeshProUGUI>().text = "Height : h=" + h;

        slant.GetComponent<TextMeshProUGUI>().text = "Slant : l=√h<sup>2</sup>+r<sup>2</sup>=" + l;   
        surfaceArea.GetComponent<TextMeshProUGUI>().text = "Surface Area : A=πr(l+r)=" +
            System.Math.Round(System.Math.PI * r*(l+r), 2);
        volume.GetComponent<TextMeshProUGUI>().text = "Volume : V=1/3xπr<sup>2</sup>h=" +
            System.Math.Round(1 / 3 * System.Math.PI * System.Math.Pow(r, 2)*h, 2);
    }
}
