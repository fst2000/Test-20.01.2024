using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    Rigidbody[] ragdoll;
    void Update()
    {
        animator.SetFloat("moveBlend", Input.GetKey(KeyCode.W) ? 1 : 0);
        if(Input.GetMouseButton(0))
        {
            bool isSpecialAttack = Random.Range(0,2) == 0;
            animator.SetBool(isSpecialAttack? "isAttackClaw" : "isAttackSpecial", true);
        }
        else
        {
            animator.SetBool("isAttackClaw", false);
            animator.SetBool("isAttackSpecial", false);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            foreach(var r in ragdoll)
            {
                r.isKinematic = false;
            }
            animator.enabled = false;
        }
    }
}
