using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            DirectionCheck();
        }
    }

    public void DirectionCheck()
    {
        //Attack direction based on camera movement direction
        if (Input.GetAxis("Mouse X") < 0 && Input.GetAxis("Mouse Y") < 1f && Input.GetAxis("Mouse Y") > -1f)
        {
            Debug.Log("Right Attack");
        }
        else if (Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") < 1f && Input.GetAxis("Mouse Y") > -1f)
        {
            Debug.Log("Left Attack");
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
}
