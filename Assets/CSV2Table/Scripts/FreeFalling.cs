using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Table;
using UnityEngine.UI;







public class FreeFalling : MonoBehaviour
{
    private bool isRunning = false;

    public float initialHeight;

    public Table csvReader;
    private Table.Row row;
    private string planet_name;

    private float gravity;

    float MinHeight = 15;

    private void Start()
    {
        planet_name = this.gameObject.name;
        row = csvReader.Find_eName(planet_name);
        gravity = float.Parse(row.gravity);
    }

    private void Reset()
    {
        //this.planet.transform.position.y = initialHeight;

    }

    public void OnSimulationButtonClick()
    {
        if (isRunning)
        {
            // Stop the simulation
            isRunning = false;
        }
        else
        {
            // Start the simulation
            isRunning = true;
        }
    }

    private void Update()
    {
        if (isRunning)
        {
            // Run your simulation code here

            // Move the object's y position up and down
            float x = transform.localPosition.x;
            float z = transform.localPosition.z;

            //gameObject.transform.localPosition = new Vector3(x, InitalHeight, z);

            float y = transform.localPosition.y - 0.5f * gravity * 0.1f * 0.1f;


            if (y < MinHeight)
            {
                y = initialHeight;
            }

            transform.localPosition = new Vector3(x, y, z);



        }
    }
}