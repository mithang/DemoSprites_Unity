using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NhanVatController : MonoBehaviour {

    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //NhanVatState chính là tên mà đã đặt bên trong animator
        if (Input.GetKey(KeyCode.A))
        {
            
            animator.SetInteger("NhanVatState", 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            animator.SetInteger("NhanVatState", 1);
        }
        else if (Input.GetKey(KeyCode.W))
        {

            animator.SetInteger("NhanVatState", 2);
        }
        else if (Input.GetKey(KeyCode.S))
        {

            animator.SetInteger("NhanVatState", 3);
        }
    }
}
