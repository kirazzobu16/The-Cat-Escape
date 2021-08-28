using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMama : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.win?.Invoke();
            Debug.Log("WINNER");
            return;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.lose?.Invoke();
            Debug.Log("LOSER");
            return;
        }




    }
}
