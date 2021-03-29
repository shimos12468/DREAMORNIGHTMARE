using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{

    public Transform target;
    private Rigidbody2D rb;
    public Transform enemyGFX;
    public float speed = 200f;
    public float NextWayPointDistance = 3f;
    private Path path;
    private int CurrentWayPoint = 0;
    private bool reachedEndPoint = false;
    Seeker seeker;
    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdatePath", 0f, 0.5f);
       
    }
    void UpdatePath()
    {
        if(seeker.IsDone())
        seeker.StartPath(rb.position, target.position, OnPathComplete);

    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            CurrentWayPoint = 0;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }
        if (CurrentWayPoint >= path.vectorPath.Count)
        {
            reachedEndPoint = true;
            return;
        }
        else
        {
            reachedEndPoint = false;
        }
        Vector2 dircetion = ((Vector2)path.vectorPath[CurrentWayPoint] - rb.position).normalized;
        Vector2 force = dircetion * speed * Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position, path.vectorPath[CurrentWayPoint]);
        if (distance < NextWayPointDistance)
        {
            CurrentWayPoint++;
        }
        if (force.x >= 0.01f)
        {
            enemyGFX.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (force.x <= -0.01f)
        {
            enemyGFX.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
