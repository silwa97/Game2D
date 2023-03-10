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
    protected Animator animator;
    protected CharacterMovement2D characterMovement;
   
   
    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        characterMovement= GetComponent<CharacterMovement2D>();

        
    }
    protected virtual void Update()
    {
        animator.SetFloat(CharacterMovementAnimationKeys.HorinzotalSpeed, characterMovement.CurrentVelocity.x / characterMovement.MaxGroundSpeed);        
    }
}
