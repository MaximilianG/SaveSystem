using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float MovementSpeed = 1.5f;
    public float JumpForce = 3;

    private Rigidbody2D _rigidbody;
    private Animator _anim;

    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
        previousPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        previousPos = transform.position;

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (previousPos != transform.position)
            _anim.SetBool("isWalking", true);
        else
        { 
            _anim.SetBool("isWalking", false);
            
        }




        if (!Mathf.Approximately(0, movement))
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            _anim.SetTrigger("Jump");
        }

    }
}
