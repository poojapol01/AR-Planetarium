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
        
        switch (selectedPlanet)
        {
            case "Mercury":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Mercury", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Venus":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Venus", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Earth":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Earth", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    //planet.name = "Earth";
                    break;
                }
            case "Mars":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Mars", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Jupiter":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Jupiter", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Saturn":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Saturn", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Uranus":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Uranus", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
            case "Neptune":
                {
                    Debug.Log("Button clicked: " + selectedPlanet);
                    planet = Instantiate(Resources.Load("Neptune", typeof(GameObject)), planetPosition, Quaternion.identity) as GameObject;
                    break;
                }
        }
    }



}
