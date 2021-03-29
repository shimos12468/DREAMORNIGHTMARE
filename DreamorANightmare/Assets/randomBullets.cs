using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBullets : MonoBehaviour
{
    public GameObject Bullet;
    public int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0f, 0f, 90f) * Time.deltaTime);
        if (counter==200)
        {

            shoot();
            counter = 0;
        }
        counter++;
    }
    public void shoot()
    {
        Instantiate(Bullet, this.transform.position, transform.rotation);
    }
}
