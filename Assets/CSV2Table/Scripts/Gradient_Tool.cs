using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gradient_Tool : MonoBehaviour
{
    public Gradient gradient;

    [Range(0.410f, 243f)]
    public float col;

    public Material mat;
    public Material white;
    public Material green;
    public Material black;


    // Start is called before the first frame update
    void Start()
    {
        mat = transform.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        mat.color = gradient.Evaluate(col);
        mat.Lerp(white, green, col);
    }
}
