using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonController : MonoBehaviour {

    Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //AnimaState chính là tên mà đã đặt bên trong animator
        if (Input.GetKey(KeyCode.A))
        {
            //Chạy
            animator.SetInteger("AnimaState",0);
        }
        else
        {
            //Đứng
            animator.SetInteger("AnimaState",1);
        }
	}
}
