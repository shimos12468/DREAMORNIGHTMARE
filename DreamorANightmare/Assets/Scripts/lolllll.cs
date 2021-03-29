using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lolllll : MonoBehaviour
{
    public float helth = 100f;
    public void takeDamage(float damage)
    {
        helth -= damage;

        if (helth <= 0)
        {
            Die();
        }

    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
