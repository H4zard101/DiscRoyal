using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outsideBounds : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player Out");
            Destroy(other.gameObject);
        }
    }

}
