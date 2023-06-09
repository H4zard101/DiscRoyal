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
        if(Input.GetMouseButtonDown(0) && canAttack)
        {
            DirectionCheck();
        }
    }

    public void DirectionCheck()
    {
        //Attack direction based on camera movement direction
        if (Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse Y") < 1f && Input.GetAxis("Mouse Y") > -1f)
        {
            anim.SetTrigger("Right");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }
        else if (Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") < 1f && Input.GetAxis("Mouse Y") > -1f)
        {
            anim.SetTrigger("Left");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }
        else if (Input.GetAxis("Mouse Y") > 0 && Input.GetAxis("Mouse X") < 1f && Input.GetAxis("Mouse X") > -1f)
        {
            anim.SetTrigger("Thrust");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }
        else if (Input.GetAxis("Mouse Y") < 0 && Input.GetAxis("Mouse X") < 1f && Input.GetAxis("Mouse X") > -1f)
        {
            anim.SetTrigger("Down");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown());
        }


        // Attack direction based on moving dirrection
        //if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") < 1f && Input.GetAxis("Vertical") > -1f)
        //{
        //    Debug.Log("Right Attack");
        //}
        //else if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") < 1f && Input.GetAxis("Vertical") > -1f)
        //{
        //    Debug.Log("Left Attack");
        //}

    }
    IEnumerator ResetAttackCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
