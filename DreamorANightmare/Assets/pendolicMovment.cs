using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendolicMovment : MonoBehaviour
{
    public float rotatespeed = 60f;
    public int damge = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.localEulerAngles = new Vector3(0f, 0f, Mathf.PingPong(Time.time * rotatespeed ,90)-45);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage( damge);
        }
    }
}
