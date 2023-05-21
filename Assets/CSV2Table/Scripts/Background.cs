using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Table;
using System;


public class Background : MonoBehaviour
{

    public Table csvReader;
    public Color startColor;
    public Color endColor;


    private Table.Row row;
    private string planet_name;
    private double mass;

    double min_mass = 7.35 * Math.Pow(10, 27);
    double max_mass = 1.99 * Math.Pow(10, 30); 

    private void Start()
    {
        planet_name = this.gameObject.name;
        row = csvReader.Find_eName(planet_name);
        mass = double.Parse(row.mass_kg);
        

        Renderer rend = GetComponent<Renderer>();
        

    }


    void Update()
    {
        Renderer renderer = GetComponent<Renderer>();

         //Interpolate color based on value

        float ratio = (float)((mass - min_mass) / (max_mass - min_mass));
        Color color = Color.Lerp(startColor, endColor, ratio);

        // Set color on game object
        renderer.sharedMaterial.color = color;

        
    }

    
}
