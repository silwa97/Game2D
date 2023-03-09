using Pada1.BBCore;
using Pada1.BBCore.Framework;
using Pada1.BBCore.Tasks;
using Platformer2D.Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Action("Game/Patrol")]
public class Patrol : BasePrimitiveAction
{
    [InParam("AIController")]
    private EnemyIAController aiController;

    [InParam("PatrolSpeed")]
    private float patrolSpeed;

    [InParam("CharacterMovement")]
    private CharacterMovement2D charMovement;
    public override void OnStart()
    {
        base.OnStart();
        charMovement.MaxGroundSpeed = patrolSpeed;
        aiController.StartCoroutine(TEMP_WALK());
    }
    public override TaskStatus OnUpdate()
    {

        return TaskStatus.RUNNING;

    }
    public override void OnAbort()
    {
        base.OnAbort();
        aiController.StopAllCoroutines();
    }
    IEnumerator TEMP_WALK()
    {
        while (true)
        {
            aiController.MovementInput=new Vector2(1,0);
            yield return new WaitForSeconds(1.0f);
            aiController.MovementInput = new Vector2(0, 0);
            yield return new WaitForSeconds(2.0f);
            aiController.MovementInput = new Vector2(-1, 0);
            yield return new WaitForSeconds(1.0f);
            aiController.MovementInput = new Vector2(0, 0);
            yield return new WaitForSeconds(2.0f);
        }
    }
}
