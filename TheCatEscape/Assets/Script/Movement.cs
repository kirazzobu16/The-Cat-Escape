using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Movement
{
    public float speed;

    public void MoveCharacter(Transform transform,float frame)
    {
        transform.Translate(Vector3.right*frame*speed);
    }
}
