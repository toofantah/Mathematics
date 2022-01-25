using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// A very simplistic car driving on the x-z plane.

public class Drive : MonoBehaviour
{

    Vector2 dir;

    void Update()
    {
        float horizental = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        dir = new Vector2(horizental, vertical);
        Vector3 position = this.transform.position;
        

        this.transform.Translate(dir*Time.deltaTime);
    }

}