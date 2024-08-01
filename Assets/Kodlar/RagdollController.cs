using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    AnimatorController controller;
    void Start()
    {
        controller = GetComponent<AnimatorController>();
        PhysicState(true);
        ColliderState(false);
        GetComponent<Animator>().enabled = true;
    }

    private void PhysicState(bool state)
    {
        Rigidbody[] ChildRigidBody = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody child in ChildRigidBody)
        {
            child.isKinematic = state;
        }
    }

    private void ColliderState(bool state)
    {
        Collider[] ChildColliders = GetComponentsInChildren<Collider>();
        foreach (Collider child in ChildColliders)
        {
            child.enabled = state;
        }
    }

    public void EnterRagdoll()
    {
        GetComponentInParent<CapsuleCollider>().enabled = false;
        GetComponentInParent<Rigidbody>().isKinematic = true;
        controller.Controller.enabled = false;

        GetComponent<Animator>().SetBool("Dying", true);
        GetComponent<Animator>().enabled = false;
        PhysicState(false);
        ColliderState(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            EnterRagdoll();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "EnterRagdoll")
        {
            EnterRagdoll();
        }
    }
}
