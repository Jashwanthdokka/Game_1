using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // Assuming that "StartMenu" is the name of your start menu scene.
    public void Quit()
    {
        SceneManager.LoadScene("Start Screen"); // Load the start menu scene.
    }
}
