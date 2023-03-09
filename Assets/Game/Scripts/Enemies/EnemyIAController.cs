using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer2D.Character;

[RequireComponent(typeof(CharacterMovement2D))]
[RequireComponent(typeof(CharacterFacing2D))]
public class EnemyIAController : MonoBehaviour
{
    CharacterMovement2D enemyMovement;
    public Vector2 movementInput;
    public bool isChasing;
    CharacterFacing2D enemyFacing;
    // Start is called before the first frame update
    void Start()
    {
        enemyMovement= GetComponent<CharacterMovement2D>();
        enemyFacing= GetComponent<CharacterFacing2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement.ProcessMovementInput(movementInput);
        enemyFacing.UpdateFacing(movementInput);
    }

}
