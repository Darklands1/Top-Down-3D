using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapFollowsCharacter : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        Vector3 newPositon = player.position;
        newPositon.y = transform.position.y;
        transform.position = newPositon;

        transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
}
