using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    public int value = 10;
    //public GameObject player;

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Here");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<player_coins>().Add_Value(value);
        }
        Destroy(gameObject);
    }
}
