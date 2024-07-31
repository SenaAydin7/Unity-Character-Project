using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class FallingRock : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject RockParticle;
    [SerializeField] GameObject BloodLake;
    GameObject PlayerObj;

    void Start()
    {
        PlayerObj = GameObject.FindGameObjectWithTag("PlayerAnimator");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" )
        {
            Instantiate(RockParticle, transform.position, Quaternion.identity) ;
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Player")
        {
            Instantiate(BloodLake, collision.contacts[0].point, Quaternion.identity, collision.gameObject.transform);
            PlayerObj.GetComponent<Animator>().SetBool("Dying", true);

        }
    }
}
