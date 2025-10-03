using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{ 

    public float movespeed;

    private float leftedge;

    private void Start()
    {
        leftedge = Camera.main.ScreenToWorldPoint(Vector2.zero).x - 1;
    }

    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;

        if(transform.position.x < leftedge)
        {
            Destroy(gameObject);
        }
    }
}
