using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float HorizontalMove = 0f;
    public CharacterController2D controler;
    public float speed = 40f;
    public bool jump = false;
    public bool crouch = false;
    int counter = 0;
    public float ImpowerdSpeed = 0f;
    public Canvas menue;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
       
        HorizontalMove = Input.GetAxisRaw("Horizontal") * (speed+ ImpowerdSpeed);

        if (HorizontalMove!=0)
        {
            Debug.Log("wkhbfwr");
            animator.SetBool("run",true);
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("jumping", true);
        }
        if (Input.GetButtonDown("crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("crouch"))
        {
            crouch = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            stopPlaying();
        }


        if (counter == 1000)
        {
            Debug.Log("Impowerd " + counter);
            ImpowerdSpeed = 0;
            counter = 0;
        }
        counter++;
    }
    private void FixedUpdate()
    {
        controler.Move(HorizontalMove * Time.fixedDeltaTime, crouch, jump);
        animator.SetBool("jumping", false);
        animator.SetBool("run", false);
        jump = false;
    }


    public void startPlaying()
    {
        gameObject.SetActive(true);
        menue.gameObject.SetActive(false);
    }
    public void stopPlaying()
    {
        gameObject.SetActive(false);
        menue.gameObject.SetActive(true);

    }
}
