using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControl : MonoBehaviour
{
    public GameObject karakter;
    public float Speed;
    public bool up=false;
    public bool left = false;
    public bool right = false;
    public bool down = false;
    //public enum Direction {Left,Right,Up,Down};
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void Update()
    {
        //karakter.transform.position += new Vector3(1,0)*Speed;
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }
    /// <summary>
    /// karakter hareketi
    /// </summary>
    private void Move()
    {
        if (Input.GetKeyDown("a") || left == true)
        {
            karakter.transform.position += new Vector3(-1, 0) * Speed;
            left = true;
        }
        if (Input.GetKeyDown("d") || right == true)
        {
            karakter.transform.position += new Vector3(1, 0) * Speed;
            right = true;
        }
        if (Input.GetKeyDown("w") || up == true)
        {
            karakter.transform.position += new Vector3(0, 1) * Speed;
            up = true;
        }
        if (Input.GetKeyDown("s") || down == true)
        {
            karakter.transform.position += new Vector3(0, -1) * Speed;
            down = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        up = false;
     left = false;
     right = false;
     down = false;
}

}

