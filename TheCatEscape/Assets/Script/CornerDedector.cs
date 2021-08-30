using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerDedector : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        GameManager.Instance.isMoving = false;
    }
}
