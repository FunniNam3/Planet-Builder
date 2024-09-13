using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public GameObject Planet;

    void FixedUpdate()
    {
        Planet.transform.Rotate(0, 0.5f, 0);
    }
}
