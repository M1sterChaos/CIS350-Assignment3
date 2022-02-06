/*
 * (Austin Buck)
 * (Assignment 3)
 * (Detects if the prefab shot hits an animal)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private DisplayScore dsc;

    private void Start()
    {
        dsc = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        dsc.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
