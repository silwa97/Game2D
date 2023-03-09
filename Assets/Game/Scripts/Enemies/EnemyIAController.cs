using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer2D.Character;

[RequireComponent(typeof(CharacterMovement2D))]
[RequireComponent(typeof(CharacterFacing2D))]
public class EnemyIAController : MonoBehaviour
{
    CharacterMovement2D enemyMovement;
    private Vector2 movementInput;
    public bool isChasing;
    CharacterFacing2D enemyFacing;

    public Vector2 MovementInput
    {
        get { return movementInput; }
        set { movementInput = new Vector2(Mathf.Clamp(value.x, -1, 1), Mathf.Clamp(value.y, -1, 1)); }
    }

    public void SetMovementInputX(float x)
    {
        movementInput.x=Mathf.Clamp(x, -1, 1);

    }
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
