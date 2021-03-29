using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_behavior : MonoBehaviour
{
    public int Damage = 100;
    public float speed = 20f;
    public  float delay = 2.0f;
    public int count = 0;
    public int Impowred = 1;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject,delay);
    }
   
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boss")
        {
            BossHealth enemy = collision.GetComponent<BossHealth>();
            if (enemy != null)
            {

                enemy.TakeDamage(Damage*Impowred);

            }
            Destroy(gameObject);
        }
        if (collision.tag == "FlayingEnemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {

                enemy.takeDamage(Damage * Impowred);

            }
            Destroy(gameObject);
        }
        if (collision.tag == "enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {

                enemy.takeDamage(Damage * Impowred);
                
            }
            Destroy(gameObject);
        }

        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<player_coins>().counter -= 4;
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(20);
            Destroy(gameObject);
        }
        //Destroy(gameObject);
        Debug.Log(collision.name);

    }
    private void Update()
    {
        
       
           
            if (count == 1000)
            {
            Debug.Log("Impowerd " +count);
            Impowred = 1;
                count = 0;
            }
            count++;
        
    }






}
