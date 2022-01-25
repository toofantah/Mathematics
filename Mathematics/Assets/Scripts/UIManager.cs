using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;
    public GameObject fuel;
    public Text tankposition;
    public Text fuelPosition;
    public Text energyAmount;

    public void AddEnergy(string amont)
    {
        int n;
        if(int.TryParse(amont, out n))
            energyAmount.text = amont;

    }

    // Start is called before the first frame update
    void Start()
    {
        tankposition.text = tank.transform.position.ToString();
        fuelPosition.text = fuel.GetComponent<ObjectManager>().objPosition.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
