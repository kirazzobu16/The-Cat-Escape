using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour
{
    public float Horizontal;
    public float Vertical;
    public float Speed;
   public bool isDamaged;
    public bool isMoving;
    public Rigidbody2D rb;
    Vector2 direction;
    public SpriteRenderer spriteRenderer;
    Sprite sprite;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
    }
    void FixedUpdate()
    {
        if (isDamaged)
        {
            isMoving = false;
                GameManager.Instance.isMoving =isMoving;
            return;
        }
        isMoving = true;
        GameManager.Instance.isMoving = isMoving;
        Shot();
    }
    
    public void Shot()
    {
        rb.AddForce(direction* Time.fixedDeltaTime * Speed);
        Debug.Log(rb.velocity);
    }
    public void YukarıGit()
    {
       
        if (isMoving)
            return;
        isDamaged = false;
        direction = Vector2.up;
    

    }
    public void AşağıGit()
    {
        if (isMoving)
            return;
        isDamaged = false;

        direction = Vector2.down;
        

    }

    public void SolaGit()
    {
        if (isMoving)
            return;
        isDamaged = false;
        direction = Vector2.left;
        

    }
    public void SağaGit()
    {
        if (isMoving)
            return;
        isDamaged = false;
        direction = Vector2.right;
        

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isDamaged = true;

       
        

    }
    
   

    // Update is called once per frame

}
