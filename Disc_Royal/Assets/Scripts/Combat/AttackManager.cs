using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public Animator anim;
    public bool canAttack = true;
    public float attackCooldown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && canAttack)
        {
            DirectionCheck();
        }
    }

    public void DirectionCheck()
    {
        //Attack direction based on camera movement direction
        if (Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse Y") < 0.15 && Input.GetAxis("Mouse Y") > -0.15)
        {
            anim.SetTrigger("Right");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }
        else if (Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") < 0.15 && Input.GetAxis("Mouse Y") > -0.15)
        {
            anim.SetTrigger("Left");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }
        else if (Input.GetAxis("Mouse Y") > 0 && Input.GetAxis("Mouse X") < 0.15 && Input.GetAxis("Mouse X") > -0.15)
        {
            anim.SetTrigger("Thrust");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }
        else if (Input.GetAxis("Mouse Y") < 0 && Input.GetAxis("Mouse X") < 0.15 && Input.GetAxis("Mouse X") > -0.15)
        {
            anim.SetTrigger("Down");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }


        //// Attack direction based on moving dirrection
        //if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") < 1f && Input.GetAxis("Vertical") > -1f)
        //{
        //    Debug.Log("Right Attack");
        //    anim.SetTrigger("Right");
        //    canAttack = false;
        //    StartCoroutine(ResetAttackCooldown());
        //}
        //else if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") < 1f && Input.GetAxis("Vertical") > -1f)
        //{
        //    Debug.Log("Left Attack");
        //    anim.SetTrigger("Left");
        //    canAttack = false;
        //    StartCoroutine(ResetAttackCooldown());
        //}

    }
    IEnumerator ResetAttackCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
