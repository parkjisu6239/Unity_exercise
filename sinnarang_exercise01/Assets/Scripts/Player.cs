using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    bool jDown;

    bool isJump;

    Vector3 moveVec;

    Rigidbody rigid;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 초기화
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
        Turn();
        Jump();
    }

    // input 변수 생성
    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        jDown = Input.GetButtonDown("Jump");
    }

    // 방향키 or WASD로 이동
    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;

        anim.SetBool("isWalk", moveVec != Vector3.zero);
    }

    // 플레이어가 진행 방향을 바라보게 만든다
    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }

    // 점프 중이 아닌 경우에만 점프 가능
    void Jump()
    {
        if (jDown && !isJump)
        {
            rigid.AddForce(Vector3.up * 13, ForceMode.Impulse);
            anim.SetBool("isJump", true);
            anim.SetTrigger("doJump");
            isJump = true;
        }
    }

    // 바닥에 닿아 있는 경우에만 점프 가능
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetBool("isJump", false);
            isJump = false;
        }
    }
}
