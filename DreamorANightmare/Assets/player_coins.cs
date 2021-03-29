using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_coins : MonoBehaviour
{

    public int counter = 0;
    public bool twiceBraker0 = false;
    public bool twiceBraker1 = false;
    public bool twiceBraker2 = false;
    
    public GameObject Bullet;
    
    void Update()
    {
        
    }

    public void Add_Value(int value)
    {
        counter += value;
        if (counter >= 200 && !twiceBraker1)
        {
            //healthBarIncrease
            gameObject.GetComponent<PlayerHealth>().health += 20;
            counter -= 200;

            twiceBraker1 = true;
            twiceBraker2 = false;
        }
        if (counter >= 100 && !twiceBraker2)
        {
            gameObject.GetComponent<movement>().ImpowerdSpeed += 5f;
            counter -= 100;

            twiceBraker1 = false;
            twiceBraker2 = true;
        }



   



    }

    private void FixedUpdate()
    {

      
    }
}
