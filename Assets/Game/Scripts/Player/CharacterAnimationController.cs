using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer2D.Character;


public static class CharacterMovementAnimationKeys
{
    public const string IsCrouching = "IsCrouching";
    public const string HorinzotalSpeed = "HorizontalSpeed";
    public const string VerticalSpeed = "VerticalSpeed";
    public const string IsGrounded = "IsGrounded";
}
public static class EnemyAnimationKeys
{
    public const string IsChasing = "IsChasing";
}

public class CharacterAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    CharacterMovement2D playerMovement;
    EnemyIAController aiController;
    PlayerController playerController;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerMovement= GetComponent<CharacterMovement2D>();
        aiController = GetComponent<EnemyIAController>();
        playerController = GetComponent<PlayerController>();
    }
    private void Update()
    {
        animator.SetFloat(CharacterMovementAnimationKeys.HorinzotalSpeed, playerMovement.CurrentVelocity.x / playerMovement.MaxGroundSpeed);
        if(playerController!= null)
        {
            animator.SetBool(CharacterMovementAnimationKeys.IsCrouching, playerMovement.IsCrouching);

            animator.SetFloat(CharacterMovementAnimationKeys.VerticalSpeed, playerMovement.CurrentVelocity.y / playerMovement.JumpSpeed);
            animator.SetBool(CharacterMovementAnimationKeys.IsGrounded, playerMovement.IsGrounded);
        }
       
        if(aiController != null)
        {
            animator.SetBool(EnemyAnimationKeys.IsChasing, aiController.isChasing);
        }
        
    }
}
