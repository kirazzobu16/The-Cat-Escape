using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControl : MonoBehaviour
{
    public float MoveUp;
    public float MoveDown;
    public float MoverRight;
    public float MoveLeft;
    // Start is called before the first frame update
    void Start()
    {
        Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * Time.deltaTime;
            
        }
 
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * MoveLeft * Time.deltaTime;
        }
 
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * MoveDown * Time.deltaTime;
        }
 
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * MoverRight * Time.deltaTime;
        }
    }
   private void OnCollisionEnter2D(Collision2D other)
    {

    }
}
