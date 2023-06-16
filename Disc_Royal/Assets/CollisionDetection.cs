using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject sparksParticle;
    public GameObject effectsPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && !AttackManager.canAttack)
        {
            Debug.Log("Hit an Enemy");
            Instantiate(sparksParticle, new Vector3(effectsPoint.transform.position.x, effectsPoint.transform.position.y, effectsPoint.transform.position.z), effectsPoint.transform.rotation);
            other.GetComponent<Rigidbody>().AddForce(transform.up * 2000, ForceMode.Impulse);
        }
    }
}
