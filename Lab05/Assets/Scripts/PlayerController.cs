using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 1.0f;
    public float backwardSpeed = 1.0f;
    public float rotateSpeed = 1.0f;
    public float jumpPower = 1.0f;

    private Animator m_animator;
    private Rigidbody m_rb;

    private int idleState;
    private int runState;
    private int jumpState;
    public Canvas canvas;
    public AudioSource audioSource;
    void Start()
    {
        m_rb = gameObject.GetComponent<Rigidbody>();
        m_animator = gameObject.GetComponent<Animator>();

        idleState = Animator.StringToHash("Base Layer.Idle");
        runState = Animator.StringToHash("Base Layer.Running");
        jumpState = Animator.StringToHash("Base Layer.Jumping");

        canvas.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AnimatorStateInfo state = m_animator.GetCurrentAnimatorStateInfo(0);
        bool jumpFlag = false;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        m_animator.SetFloat("Speed", v);
        m_animator.SetFloat("Direction", h);

        Vector3 velocity = new Vector3(0.0f, 0.0f, v);

        gameObject.transform.Rotate(0, h * rotateSpeed, 0);
        float coef = 1.0f;
        if (jumpFlag)
        {
            coef = 0.6f;
        }
        if (v < -0.1)
        {
            gameObject.transform.Translate(velocity * backwardSpeed * Time.fixedDeltaTime);
        }
        else if (v > 0.1)
        {
            gameObject.transform.Translate(velocity * forwardSpeed * coef * Time.fixedDeltaTime);
        }


        if (state.fullPathHash == runState)
        {
            // When character is moving, she can jump now
            if (Input.GetKey(KeyCode.Space))
            {
                // The controller is not transition 
                if (!m_animator.IsInTransition(0))
                {
                    // Enable "Jump" 
                    m_animator.SetBool("Jump", true);
                    // Add jump force to rigidbody
                    m_rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
                }
            }
        }
        else if (state.fullPathHash == jumpState)
        {
            // Disable "Jump" 
            m_animator.SetBool("Jump", false);

            jumpFlag = true;

        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ghost")
        {
            canvas.enabled = true;
            audioSource.Stop();

        }
    }

}
