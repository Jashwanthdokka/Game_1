using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Check if all stars are collected in the level.
            GameObject[] stars = GameObject.FindGameObjectsWithTag("star");
            if (stars.Length == 0)
            {
                if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
                {
                    SceneManager.LoadScene(currentSceneIndex + 1);
                }
                else
                {  
                     SceneManager.LoadScene("End Screen"); 
                }
            }
            else
            {
                // Player has not collected all stars, do not progress to the next level.
                Debug.Log("Collect all stars before progressing to the next level!");
            }
        }
    }
}
