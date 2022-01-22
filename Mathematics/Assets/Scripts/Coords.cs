using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coords : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;

    public Coords(float _X, float _Y)
    {
        X = _X;
        Y = _Y;
        Z = -1;
    }

    public override string ToString()
    {
        return "(" + X + "," + Y + "," + Z + ")"; 
    }

    static public void DrawPoint(Coords position, float width, Color calour)
    {
        GameObject line = new GameObject("Points_" + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = calour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.X - width / 3.0f, position.Y - width / 3.0f, position.Z));
        lineRenderer.SetPosition(1, new Vector3(position.X + width / 3.0f, position.Y + width / 3.0f, position.Z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
        
    }

    static public void DrawLine(Coords startPoint,Coords endPoint, float width, Color calour)
    {
        GameObject line = new GameObject("Line_" + startPoint.ToString()+"_"+endPoint.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = calour;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPoint.X , startPoint.Y , startPoint.Z));
        lineRenderer.SetPosition(1, new Vector3(endPoint.X, endPoint.Y, endPoint.Z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;

    }
}
