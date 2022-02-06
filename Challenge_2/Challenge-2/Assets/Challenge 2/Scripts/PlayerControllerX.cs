/*
 * (Austin Buck)
 * (Assignment 3)
 * (Controls when player throws dogs)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canShoot = false;
            StartCoroutine(canShootAgain());
        }
    }

    IEnumerator canShootAgain()
    {
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
}
