using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDamge : MonoBehaviour
{
    public int Damge = 2000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(Damge);
        }
    }
}
