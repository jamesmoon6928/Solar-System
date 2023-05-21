using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Table;
using UnityEngine.UI;







public class SunFall : MonoBehaviour
{
    private bool isRunning = false;

    public float InitialHeight;

    //public Table csvTable;

    float MinHeight = 15;

    private void Reset()
    {
        InitialHeight = gameObject.transform.localPosition.y;

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
            float x = gameObject.transform.localPosition.x;
            float z = gameObject.transform.localPosition.z;

            //gameObject.transform.localPosition = new Vector3(x, InitalHeight, z);

            float y = gameObject.transform.localPosition.y - 0.5f * 274f * 0.1f * 0.1f;


            if (y < MinHeight)
            {
                y = InitialHeight;
            }

            gameObject.transform.localPosition = new Vector3(x, y, z);



        }
    }
}