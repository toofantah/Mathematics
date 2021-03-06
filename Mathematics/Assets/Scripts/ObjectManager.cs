using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objPrefab;
    public Vector3 objPosition;
    // Start is called before the first frame update
    void Awake()
    {
       GameObject instance = Instantiate(objPrefab, new Vector3(Random.Range(-100, 100),
            Random.Range(-100, 100), objPrefab.transform.position.z),
            Quaternion.identity);

        objPosition = instance.transform.position;

        print("The fuel is at location of:" + instance.transform.position.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
