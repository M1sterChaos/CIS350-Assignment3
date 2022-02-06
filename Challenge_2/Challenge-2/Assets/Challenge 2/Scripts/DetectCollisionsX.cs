/*
 * (Austin Buck)
 * (Assignment 3)
 * (Detects when dog hits ball and adds score)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private ScoreManager sm;

    private void Start()
    {
        sm = GameObject.FindGameObjectWithTag("ScoreBoard").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Dog"))
        {
            sm.score++;
        }
        Destroy(gameObject);
    }
}
