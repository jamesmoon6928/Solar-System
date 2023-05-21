using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Define the arrow length and color
    public float arrowLength = 1.0f;
    public Color arrowColor = Color.white;

    // Define the arrow head and tail prefabs
    public GameObject arrowHeadPrefab;
    public GameObject arrowTailPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Create the arrow head and tail game objects
        GameObject arrowHead = Instantiate(arrowHeadPrefab, transform.position, transform.rotation);
        GameObject arrowTail = Instantiate(arrowTailPrefab, transform.position, transform.rotation);

        // Set the arrow head and tail colors
        arrowHead.GetComponent<Renderer>().material.color = arrowColor;
        arrowTail.GetComponent<Renderer>().material.color = arrowColor;

        // Set the arrow head and tail positions and scales
        arrowHead.transform.position = transform.position + arrowLength * transform.forward;
        arrowTail.transform.position = transform.position;
        arrowHead.transform.localScale = 0.05f * arrowLength * Vector3.one;
        arrowTail.transform.localScale = 0.02f * arrowLength * Vector3.one;

        // Attach the arrow head and tail to the game object
        arrowHead.transform.parent = transform;
        arrowTail.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the arrow head and tail positions based on the game object's position and rotation
        transform.GetChild(0).position = transform.position + arrowLength * transform.forward;
        transform.GetChild(1).position = transform.position;
        transform.GetChild(0).rotation = transform.rotation;
        transform.GetChild(1).rotation = transform.rotation;
    }
}
