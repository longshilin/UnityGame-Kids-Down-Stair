using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    readonly float leftBorder = -3; // 右边界
    readonly float rightBorder = 3; // 左边界
    readonly float m_initPositionY = 0;

    [Range(2, 6)]
    [SerializeField]
    private float spacingY;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject newGround = Instantiate(Resources.Load<GameObject>("地板"));
            float newGroundPositionY = m_initPositionY - spacingY * i;
            newGround.transform.position = new Vector3(NewGroundPositionX(), newGroundPositionY, 0);
        }
    }

    float NewGroundPositionX()
    {
        return Random.Range(leftBorder, rightBorder);
    }

    void Update()
    {
    }
}