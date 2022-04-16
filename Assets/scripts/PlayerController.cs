using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator playerAnimator;
    float input_x = 0;
    float input_y = 0;
    public float speed = 2.5f;
    bool is_walking = false;

    public FixedJoystick joystickFixed;
    private float xPos;
	private float yPos;

    void Start()
    { 
        is_walking = false;
    }

    // Update is called once per frame
    void Update()
    {
        //input_x = Input.GetAxisRaw("Horizontal");
        //input_y = Input.GetAxisRaw("Vertical");

        input_x = joystickFixed.Horizontal;
        input_y = joystickFixed.Vertical;

        xPos = transform.position.x;
		yPos = transform.position.y;

        is_walking = (input_x != 0 || input_y != 0);

        if (is_walking){
            //Debug.Log("xPos: " + input_x + ", yPos: " + input_y);

            //entrar na casa
            if (yPos > 10.4 && yPos < 11.46597){
                if (xPos > -10.7 && xPos < -10){
                    this.transform.position = new Vector3(-5.01f, -43.8f, 0);
                }
            }
            //sair da casa
            if (yPos > -44.91691 && yPos < -44.518581){
                if (xPos > -5.355583 && xPos < -4.60466){
                    this.transform.position = new Vector3(-10.57f, 10.24f, 0);
                }
            }

            //entrar na loja
            if (yPos > 11 && yPos < 11.46597){
                if (xPos > -0.7299645 && xPos < -0.3121853){
                    this.transform.position = new Vector3( 10.00465f, -43.88578f, 0);
                }
            }
            //sair da loja
            if (yPos > -44.67365 && yPos < -44.37486){
                if (xPos > 9.720733 && xPos < 10.33231){
                    this.transform.position = new Vector3(-0.5917944f, 10.65416f, 0);
                }
            }

            //entrar na escola
            if (yPos > 10.31356 && yPos < 10.55414){
                if (xPos > 11 && xPos < 12){
                    this.transform.position = new Vector3( 36f, -33.66375f, 0);
                }
            }
            //sair da escola
            if (yPos > -33.02071 && yPos < -32.36921){
                if (xPos > 35.79257 && xPos < 36.31467){
                    this.transform.position = new Vector3(11.55521f, 9.894915f, 0);
                }
            }

            var move = new Vector3(input_x, input_y, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            playerAnimator.SetFloat("input_x", input_x);
            playerAnimator.SetFloat("input_y", input_y);
        }

        playerAnimator.SetBool("is_walking", is_walking);
    }
}
