using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Döndürme iþlemi yapar.
/// </summary>
/// 
[System.Serializable]
public struct Rotate
{
    private float move;
    private Vector2 targetPos;
    private Vector3 thisPos;
    public float angle;
    /// <summary>
    /// Karakterin dönme iþlemi tetiklenir.
    /// </summary>
    /// <param name="direction"></param>
    public void RotateCharacter(Transform transform, Vector2 direction)
    {
      
       targetPos = (Vector2)transform.position+ direction;
       thisPos = transform.position;
       targetPos.x = targetPos.x - thisPos.x;
       targetPos.y = targetPos.y - thisPos.y;
       angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
     //if(angle<45&&angle<0)
     //   {
     //       transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
     //   }
     //else if(angle>45&&angle<135)
     //   {
     //       transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
     //   }
     //else if(angle>90&&angle<180)
     //   {
     //       transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
     //   }
     

    }
}