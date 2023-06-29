using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public Animator anim;
    public static bool canAttack = true;
    public float attackCooldown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Fire1") == 1 && canAttack)
        {
            AttackDirectionCheck();
        }
        if(Input.GetMouseButton(1) && canAttack)
        {
            BlockDirectionCheck();
        }
    }

    public void AttackDirectionCheck()
    {
        //Attack direction based on camera movement direction
        if (Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse Y") < 0.15 && Input.GetAxis("Mouse Y") > -0.15)
        {
            anim.SetTrigger("Right");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(1f));
        }
        else if (Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") < 0.15 && Input.GetAxis("Mouse Y") > -0.15)
        {
            anim.SetTrigger("Left");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(1f));
        }
        else if (Input.GetAxis("Mouse Y") > 0 && Input.GetAxis("Mouse X") < 0.15 && Input.GetAxis("Mouse X") > -0.15)
        {
            anim.SetTrigger("Thrust");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(1f));
        }
        else if (Input.GetAxis("Mouse Y") < 0 && Input.GetAxis("Mouse X") < 0.15 && Input.GetAxis("Mouse X") > -0.15)
        {
            anim.SetTrigger("Down");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(1f));
        }
    }
    public void BlockDirectionCheck()
    {
        //Attack direction based on camera movement direction
        if (Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse Y") < 0.15 && Input.GetAxis("Mouse Y") > -0.15)
        {
            anim.SetTrigger("BlockLeft");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(0.45f));
        }
        else if (Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") < 0.15 && Input.GetAxis("Mouse Y") > -0.15)
        {
            anim.SetTrigger("BlockRight");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(0.45f));
        }
        else if (Input.GetAxis("Mouse Y") > 0 && Input.GetAxis("Mouse X") < 0.15 && Input.GetAxis("Mouse X") > -0.15)
        {
            anim.SetTrigger("BlockUp");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(0.45f));
        }
        else if (Input.GetAxis("Mouse Y") < 0 && Input.GetAxis("Mouse X") < 0.15 && Input.GetAxis("Mouse X") > -0.15)
        {
            anim.SetTrigger("BlockDown");
            canAttack = false;
            StartCoroutine(ResetAttackCooldown(0.45f));
        }
    }
    IEnumerator ResetAttackCooldown(float time)
    {
        yield return new WaitForSeconds(0.45f);
        canAttack = true;
    }
}
