using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static Table;

public class Description_When_Hover : MonoBehaviour
{
    public Table csvReader;

    public string planet_name;

    public GameObject hoverpanel;

    public Text uiName;
    public Text gravity;
    public Text radius;
    public Text density;
    public Text mass;

    private Table.Row row;


    private void Start()
    {
        //csvReader.GetComponents<Table>();
        //rowList = csvReader.GetRowList();
        gravity = gravity.GetComponent<Text>();
        radius = radius.GetComponent<Text>();
        density = density.GetComponent<Text>();
        mass = mass.GetComponent<Text>();
    }

    public void OnMouseEnter()
    {
        planet_name = this.gameObject.name;
        uiName.text = planet_name;
        row = csvReader.Find_eName(planet_name);
        gravity.text = row.gravity;
        radius.text = row.meanRadius;
        density.text = row.density;
        mass.text = row.mass_kg;

        hoverpanel.SetActive(true);

    }

    public void OnMouseExit()
    {
        planet_name = "";
        hoverpanel.SetActive(false);
        gravity.text = "";
    }
}
