using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{

    private void Awake()
    {
        StartCoroutine(DestroySystem());
    }

    IEnumerator DestroySystem()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
}
