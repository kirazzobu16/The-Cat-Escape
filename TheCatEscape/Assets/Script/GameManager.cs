using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent win;
    public UnityEvent lose;
    public bool isMoving;
    public static GameManager Instance{ get; private set; }
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null) 
        {
            Destroy(this);
            return;

        }
        Instance = this;
    }
   



}
