using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradient_Tool_IMG : MonoBehaviour
{
    public Gradient gradient;

    [Range(0.410f, 243f)]
    public float col = 1;

    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = transform.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color = gradient.Evaluate(col);
    }
}
