using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class actionScript : MonoBehaviour
{
    private Rigidbody2D TheBody;
    public float jumpHeight;
    public float downforce;
    private bool canJump = true;
    private Animator animator;

    private void Awake()
    {
        TheBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            animator.SetBool("jumping", true);
            TheBody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            canJump = false;
        }
        if(TheBody.velocity.y < 0)
        {
            TheBody.AddForce(Vector2.up * Physics2D.gravity.y * downforce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            animator.SetBool("jumping", false);
            canJump = true;
        }
        if (collision.gameObject.tag == "obstacle")
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}
