using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    float hAxis;
    float vAxis;
    bool rDown;

    Vector3 moveVec;
    public float moveSpeed;
    Animator anim;
    // Start is called before the first frame update
   
   void Awake(){
        anim = GetComponentInChildren<Animator>();
   }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        rDown = Input.GetButton("Run");

        moveVec = new Vector3(hAxis,0,vAxis).normalized;


        //쉬프트키 눌렀을경우 속도증가, 아닐경우 속도감소
        transform.position += moveVec * moveSpeed * (rDown ? 1f : 0.3f)* Time.deltaTime ;

        anim.SetBool("isWalk", moveVec != Vector3.zero);
        anim.SetBool("isRun", rDown);

        transform.LookAt(transform.position + moveVec);
        
    }
}
