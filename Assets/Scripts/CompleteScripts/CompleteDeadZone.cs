using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteDeadZone : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("玩家"))
        {
            CompletePlayer.isDead = true;
            //Debug.Break();
        }
    }
}