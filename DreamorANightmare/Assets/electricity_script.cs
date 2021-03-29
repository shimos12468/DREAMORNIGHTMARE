using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricity_script : MonoBehaviour
{
    public int damge = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("here" +" " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("here" + " " + collision.gameObject.tag);
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damge) ;
        }
    }
}
