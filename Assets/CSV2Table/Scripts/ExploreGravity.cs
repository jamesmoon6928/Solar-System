using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using UnityEngine;

public class ExploreGravity : MonoBehaviour
{

    [Tooltip("Please enter a value between 5 and 100." +
        "We suggest that keep this variable constant if you are exploring" + "" +
		"the relationship between gravity and radius")]
    public float mass = 50.00f;

    [Tooltip("Plese enter a value between 20 and 100" +
        "We suggest that keep this variable constant if you are exploring" + "" +
        "the relationship between gravity and mass")]
    public float radius = 50.00f;

    public Text numberText;

    public Color startColor;
    public Color endColor;




    private float massi = 50.00f;
    private float radiusi = 50.00f;
    private float minmass = 0;
    private float maxmass = 100;
    private float gravity = 12.00f;

 




    //gtp
    void OnValidate()
    {
        Renderer renderer = GetComponent<Renderer>();

        // Interpolate color based on value
        Color color = Color.Lerp(startColor, endColor, (mass-minmass)/(maxmass-minmass));

        // Set color on game object
        renderer.sharedMaterial.color = color;
    }


    void Update()
    {
        float c = gravity * (mass / massi) / (radius / radiusi) / (radius / radiusi);
        numberText.text = "Gravity: " + c.ToString() +"m/s^2";
        transform.localScale = new Vector3(radius, radius, radius);

        
    }

       public void SetMassFromInput(string newValue)
{
    float parsedValue;
    if (float.TryParse(newValue, out parsedValue))
    {
        mass = parsedValue;

        // Update color based on new value
        Renderer renderer = GetComponent<Renderer>();
        Color color = Color.Lerp(startColor, endColor, (mass-minmass)/(maxmass-minmass));
        renderer.sharedMaterial.color = color;
    }

}
    public void SetRadiusFromInput(string newValue)
{
    float parsedValue;
    if (float.TryParse(newValue, out parsedValue))
    {
        radius = parsedValue;
    }
}

}
