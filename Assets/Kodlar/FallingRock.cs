using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject ParticleEffect;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" )
        {
            Instantiate(ParticleEffect, transform.position, Quaternion.identity) ;
            Destroy(gameObject);
        }
    }
}
