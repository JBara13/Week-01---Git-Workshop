using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [SerializeField] private bool isShooting = false;

    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            // SHOOT FUNCTION GOES HERE
            Debug.Log("oh yeah");
            isShooting = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isShooting = false;   
        }

        if (!isShooting)
        {
            Debug.Log("ratatata");
        }

    }
}
