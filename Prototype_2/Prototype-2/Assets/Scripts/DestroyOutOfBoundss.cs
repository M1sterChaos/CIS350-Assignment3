/*
 * (Austin Buck)
 * (Assignment 3)
 * (When out of bounds, that prefab will despawn)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundss : MonoBehaviour
{
    public float topBound;
    public float bottomBound;

    private HealthSystem hs;
    // Start is called before the first frame update
    void Start()
    {
        topBound = 20;
        bottomBound = -10;
        hs = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < bottomBound)
        {
            hs.TakeDamage();
            Destroy(gameObject);
        }
    }
}
