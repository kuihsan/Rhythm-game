using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour
{
    Animator animator;
    int IsWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("IsWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool("IsWalking");
        bool forwardPressed = Input.GetKey("w") || Input.GetKey("up");

        if (!IsWalking && forwardPressed)
        {
            animator.SetBool(IsWalkingHash, true);
        }

        if (IsWalking && !forwardPressed)
        {
            animator.SetBool(IsWalkingHash, false);
        }
    }
}
