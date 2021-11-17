using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public Animator playerAnimator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DirectionCheck();
        }
    }

    void DirectionCheck()
    {
        if(Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse Y") < 0.15f && Input.GetAxis("Mouse Y") > -0.15f)
        {
            playerAnimator.SetTrigger("AttackRight");
        }
        else if (Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") < 0.15f && Input.GetAxis("Mouse Y") > -0.15f)
        {
            playerAnimator.SetTrigger("AttackLeft");
        }
        else if (Input.GetAxis("Mouse Y") > 0 && Input.GetAxis("Mouse X") < 0.15f && Input.GetAxis("Mouse X") > -0.15f)
        {
            playerAnimator.SetTrigger("AttackStab");
        }
        else if (Input.GetAxis("Mouse Y") < 0 && Input.GetAxis("Mouse X") < 0.15f && Input.GetAxis("Mouse X") > -0.15f)
        {
            playerAnimator.SetTrigger("AttackUp");
        }
    }
}

