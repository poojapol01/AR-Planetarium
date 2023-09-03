using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlanetObjectController : MonoBehaviour
{
    //public GameObject[] planetOjects;
    public GameObject PlanetObject;
    private Vector3 planetPosition = new Vector3(0f, 0f, 4f);
    //private Vector3 planetRotation = new Quaternion(0f, 0f, 0f);
    public void GetButtonName()
    {
        SceneManager.LoadScene("Planets");
        string clickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("Button which is clicked: " +clickedButtonName);


        switch (clickedButtonName)
        {
            case "Earth":
                {
                    Debug.Log("Button clicked: " + clickedButtonName);
                    Instantiate(PlanetObject);
                    break;
                }
            case "Mars":
                {
                    Debug.Log("Button clicked: " + clickedButtonName);
                    Instantiate(PlanetObject, planetPosition, Quaternion.identity);
                    break;
                }
            case "Saturn":
                {
                    Debug.Log("Button clicked: " + clickedButtonName);
                    Instantiate(PlanetObject, planetPosition, Quaternion.identity);
                    break;
                }
        }
    }



}
