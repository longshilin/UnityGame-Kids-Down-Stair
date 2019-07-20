using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forceX; // 水平推力

    Rigidbody2D playerRigidBody2D; // 玩家刚体
    readonly float toLeft = -1;    // 向左推力
    readonly float toRight = 1;    // 向右推力
    readonly float stop = 0;       // 静止推力
    float directionX;              // 水平方向

    void Start()
    {
        playerRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 输入水平方向并给刚体施加该方向上的推力
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            directionX = toLeft;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            directionX = toRight;
        }
        else
        {
            directionX = stop;
        }

        Vector2 newDirection = new Vector2(directionX, 0);
        playerRigidBody2D.AddForce(newDirection * forceX);
    }
}