using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    Coords[] points = { new Coords(0, 50), new Coords(50, 45), new Coords(70, 35), new Coords(75, 25) };
   

    Coords startPosX = new Coords(-160, 0);
    Coords endPosX = new Coords(160, 0);

    Coords startPosY = new Coords(0, 100);
    Coords endPosY = new Coords(0, -100);

    void Start()
    {

        Coords.DrawLine(startPosX, endPosX, 0.5f, Color.red);
        Coords.DrawLine(startPosY, endPosY, 0.5f, Color.green);
        //Coords.DrawPoint(new Coords(0, 0), 2, Color.red);
        foreach (Coords C in points)
        {
            Coords.DrawPoint(C, 2, Color.yellow);
            Debug.Log(C.ToString());
        }


        Coords.DrawLine(points[0], points[1], 0.5f, Color.white);
        Coords.DrawLine(points[1], points[2], 0.5f, Color.white);
        Coords.DrawLine(points[2], points[3], 0.5f, Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
