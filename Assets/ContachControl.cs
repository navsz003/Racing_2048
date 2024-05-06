using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContachControl : MonoBehaviour
{

    private Animator ani;
    private Rigidbody2D rBody;

    void Start()
    {
        ani = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        ani.SetFloat("Horizontal", horizontal);
        
    }
}
