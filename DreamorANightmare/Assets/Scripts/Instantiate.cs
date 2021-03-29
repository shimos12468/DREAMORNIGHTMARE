using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instantiate : MonoBehaviour
{
    public GameObject enemy;
    public GameObject wall;
    // public GameObject vectory;
    private bool once = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && once == true)
        {
            Instantiate(enemy, gameObject.transform);
            //enemy.GetComponent<Boss>().player = collision.transform;
            gameObject.GetComponent<Collider2D>().enabled = false;

            wall.gameObject.SetActive(true);

            once = false;

        }
    }
}

