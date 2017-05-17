using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public Animator Anim;
    public Rigidbody2D PlayerRigidbody;
    public int forcejump;

    public bool jump;
    public bool bebado;

    //VERIFICA O CHAO
    public Transform GroundCheck;
    public bool grounded;
    public LayerMask WhatIsGround;

    //colisor
    public Transform colisor;

    


    void Start () {
        
	}
	
	
	void Update () {
        //Click botão de pular
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            PlayerRigidbody.AddForce(new Vector2(0, forcejump));
            
        }

        if (Input.GetButtonDown("Bebado"))
        {

            bebado = true;
        }

        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.2f, WhatIsGround);

        Anim.SetBool("jump", !grounded);

    }

    private void OnTriggerEnter2D()
    {
        
    }

}
