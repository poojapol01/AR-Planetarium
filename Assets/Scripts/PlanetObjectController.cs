using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlanetObjectController : MonoBehaviour
{
    private Vector3 planetPosition = new Vector3(0f, 0f, 4f);
    GameObject planet;
    public void Start()
    {
        string selectedPlanet = PlayerPrefs.GetString("SelectedPlanet");
        Debug.Log("Button which is clicked: " + selectedPlanet);
        
        switch (selectedPlanet)
        {
            case "Earth":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Earth", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    planet.name = "Earth";
                    break;
                }
            case "Mars":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Mars", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Saturn":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Saturn", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
        }
    }



}
