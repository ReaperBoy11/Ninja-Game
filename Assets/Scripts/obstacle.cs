using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private Rigidbody2D Obstacle;

    public float movespeed;

    private float leftedge;

    private void Start()
    {
        leftedge = Camera.main.ScreenToWorldPoint(Vector2.zero).x - 1;
    }

    private void Awake()
    {
        Obstacle = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Obstacle.transform.position += Vector3.left * movespeed * Time.deltaTime;

        if(Obstacle.transform.position.x < leftedge)
        {
            Destroy(gameObject);
        }
    }
}
