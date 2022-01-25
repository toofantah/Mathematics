using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{
   

    void Update()
    {
        Vector3 position = this.transform.position;
        position.x += 0.1f;
        position.y += 0.1f;

        this.transform.position = position;
    }

}