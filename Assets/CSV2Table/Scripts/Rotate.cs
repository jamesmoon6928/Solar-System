using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool rotationEnabled = true; // new variable to enable/disable rotation
    public Button toggleButton; // reference to the UI button

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleRotation); // listen to button click event
    }

    void Update()
    {
        if (rotationEnabled) // only rotate if enabled
        {
            transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
        }
    }

    void ToggleRotation()
    {
        rotationEnabled = !rotationEnabled; // toggle rotation enabled/disabled
    }
}
