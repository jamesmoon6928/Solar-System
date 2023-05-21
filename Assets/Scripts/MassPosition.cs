using UnityEngine;
using UnityEngine.UI;

public class MassPosition : MonoBehaviour
{
    public Button changePositionButton;
    public GameObject Sun;
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Moon;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;



    private void Start()
    {
        // Add a listener to the button click event
        changePositionButton.onClick.AddListener(ChangePosition);
    }

    private void ChangePosition()
    {
        // Change the position of the game object
        Sun.transform.position = new Vector3(16f, 75f, 0f - 40f);
        Jupiter.transform.position = new Vector3(16f, 75f, 15f);
        Saturn.transform.position = new Vector3(16f, 75f, -5f);
        Neptune.transform.position = new Vector3(16f, 75f, 1f);
        Uranus.transform.position = new Vector3(16f, 75f, 7f);
        Earth.transform.position = new Vector3(16f, 75f, 12f);
        Venus.transform.position = new Vector3(16f, 75f, 23f);
        Mars.transform.position = new Vector3(16f, 75f, 40f);
        Mercury.transform.position = new Vector3(16f, 75f, 53f);
        Moon.transform.position = new Vector3(16f, 75f, 65f);
    }
}
