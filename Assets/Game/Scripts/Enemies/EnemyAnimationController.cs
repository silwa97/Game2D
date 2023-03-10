using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationController : CharacterAnimationController
{
    EnemyIAController aiController;
    protected override void Awake()
    {
        base.Awake();
        aiController = GetComponent<EnemyIAController>();
    }
    protected override void Update()
    {
        base.Update();
        animator.SetBool(EnemyAnimationKeys.IsChasing, aiController.isChasing);
    }
}

