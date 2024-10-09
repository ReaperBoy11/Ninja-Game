using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionScript : MonoBehaviour
{
    public Rigidbody2D TheBody;
    public float jumpHeight;
    public float downforce;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TheBody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
        if(TheBody.velocity.y < 0)
        {
            TheBody.AddForce(Vector2.up * Physics2D.gravity.y * downforce * Time.deltaTime, ForceMode2D.Impulse); //copied from a video
        }
    }
}
