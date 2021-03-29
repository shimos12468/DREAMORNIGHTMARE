using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepoone : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;
    public Animator animator;
    //public int Damage = 30;
    //public GameObject ImpactEffect;
    //public LineRenderer lineRenderer;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("shooting", false);
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("shooting", true);
            Debug.Log("hiiii");
           
            Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
           // shoot();
           

        }
        
    }

    public void shoot()
    {
       
     
       
        /*RaycastHit2D ray = Physics2D.Raycast(firepoint.position, firepoint.right);
        if (ray)
        {
            if (ray.transform.tag == "Boss")
            {
                BossHealth enemy = ray.transform.GetComponent<BossHealth>();
                if (enemy != null)
                {

                    enemy.TakeDamage(Damage);

                }
            }
            if (ray.transform.tag == "FlayingEnemy")
            {
                Enemy enemy = ray.transform.GetComponent<Enemy>();
                if (enemy != null)
                {

                    enemy.takeDamage(Damage);

                }

            }
            if (ray.transform.tag == "enemy")
            {
                Enemy enemy = ray.transform.GetComponent<Enemy>();
                if (enemy != null)
                {

                    enemy.takeDamage(Damage);

                }

            }
            
        }
        else
        {
            lineRenderer.SetPosition(0, firepoint.position);
            lineRenderer.SetPosition(1, firepoint.position+firepoint.right*100);
        }*/


    }
}
