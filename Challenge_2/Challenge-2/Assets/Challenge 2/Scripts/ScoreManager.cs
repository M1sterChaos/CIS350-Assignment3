/*
 * (Austin Buck)
 * (Assignment 3)
 * (Controls score and win text)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreBox;
    public GameObject wintext;

    public int score = 0;

    // Update is called once per frame
    void Update()
    {
        scoreBox.text = "Score: " + score;

        if(score >= 5)
        {
            wintext.SetActive(true);
            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
