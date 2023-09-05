using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SwitchScenes(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
        PlayerPrefs.SetString("SelectedPlanet", EventSystem.current.currentSelectedGameObject.name);
    }
}
