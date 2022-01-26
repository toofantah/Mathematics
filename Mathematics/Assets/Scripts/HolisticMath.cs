using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolisticMath
{
    static public Coords GetNormal(Coords vector)
    {
        float length = Distance(new Coords(0, 0, 0), vector);
        vector.x /= length;
        vector.y /= length;
        vector.z /= length;

        return vector;
    }

    static public float Distance(Coords point1, Coords point2)
    {
        return Mathf.Sqrt(Square(point1.x - point2.x) + 
                          Square(point1.y - point2.y) + 
                          Square(point1.z- point2.z));
    }

    static public float Square(float value)
    {
        return value * value;
    }

    static public float DotProduct(Coords vector1, Coords vector2)
    {
        float d = (vector1.x * vector2.x) + (vector1.y * vector2.y) + (vector1.z * vector2.z);
        return d;
    }

    static public float Angle(Coords vector1, Coords vector2)
    {
        float d = DotProduct(vector1, vector2);
        float distanceVector1 = Distance(new Coords(0, 0, 0), vector1);
        float distanceVector2 = Distance(new Coords(0, 0, 0), vector2);
        float dotDevide = d / (distanceVector1 * distanceVector2);

        return Mathf.Acos(dotDevide); // this returns in radian 
                                      // if we want degree we need to * 180/Mathf.PI;
    }

    static public float AngleToDegree(float radian)
    {
        return radian * 180 / Mathf.PI;
    }

    static public Coords Rotate(Coords vector, float angle, bool clockwise)// in radians
    {
        if (clockwise)
        {
            angle = 2 * Mathf.PI - angle;
        }
        float xValue = vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle);
        float yValue = vector.x * Mathf.Sin(angle) - vector.y * Mathf.Cos(angle);

        return new Coords(yValue, yValue, 0);                                                                                                                                                                                                                                                              
    }

    static public Coords CrossProduct(Coords vector1, Coords vector2)
    {
        float x = (vector1.y * vector2.z) - (vector2.y * vector1.z);
        float y = (vector1.x * vector2.z) - (vector2.x * vector1.z);
        float z = (vector1.x * vector2.y) - (vector1.y * vector2.x);
        Coords cross = new Coords(x,y,z);
        return cross;
    }
}
