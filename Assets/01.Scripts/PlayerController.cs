using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigid;
    [SerializeField] private int jumpPower;
    [SerializeField] public int moveSpeed;
    private bool isJumping;
    private Animator animator;
    private bool isMoving;
    [SerializeField] private GameObject Item1;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        isJumping = false;
    }
    private void Update()
    {
        PlayerMove();
        PlayerJump();
    }
    private void PlayerMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");

        transform.Translate((new Vector3(x, 0, 0) * moveSpeed) * Time.deltaTime);
    }
    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                isJumping = true;
                rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
            else
            {
                return;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

        if (collision.gameObject.CompareTag("Obj"))
        {
            animator.SetTrigger("Die");
            SceneManager.LoadScene("GameOver");
        }

        if (collision.gameObject.CompareTag("Item"))
        {
            StartCoroutine(MoveStop());
        }

        if (collision.gameObject.CompareTag("Item2"))
        {
            StartCoroutine(MoveFast());
        }
    }
    IEnumerator MoveStop()
    {
        moveSpeed = 0;
        yield return new WaitForSeconds(2f);
        moveSpeed = 10;
    }
    IEnumerator MoveFast()
    {
        moveSpeed = 20;
        yield return new WaitForSeconds(2.3f);
        moveSpeed = 10;
    }
}

