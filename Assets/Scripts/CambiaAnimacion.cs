using System;
using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("velocidad",Math.Abs(rb.linearVelocityX));
    }
}
