using SUPERCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    [SerializeField] SUPERCharacterAIO Controller;
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (Input.GetKey(KeyCode.Q) && animator.GetFloat("Speed") < 0.3f)
        {
            animator.SetBool("Dance", true);
            Controller.enableMovementControl = false;
            Controller.canJump = false;
        }
        else if (Input.GetKey(KeyCode.K) && animator.GetFloat("Speed") < 0.5f)
        {
            if (animatorStateInfo.IsName("Idle Walk Run Blend"))
            {
                animator.SetBool("Sitting", true);
                Controller.enableMovementControl = false;
                Controller.canJump = false;

            }
            else if (animatorStateInfo.IsName("Sitting"))
            {
                animator.SetBool("Sitting", false);
                Controller.enableMovementControl = true;
                Controller.canJump = true;

            }

        }

        
        else if(!animator.GetBool("Sitting"))
        {
            animator.SetBool("Dance", false);
            Controller.enableMovementControl = true;
            Controller.canJump = true;
            Debug.Log("Hareket edebilir");

        }

        
        
    }
}
