using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControl : MonoBehaviour
{
    Rigidbody rb;
    public Movement movement;
    public Rotate rotate;
    public VariableJoystick variableJoystick;
    public GameObject karakter;
    public float Speed;
    public bool up=false;
    public bool left = false;
    public bool right = false;
    public bool down = false;
    public Vector2 direction;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // void Update()
    //{
    //    //karakter.transform.position += new Vector3(1,0)*Speed;

    //    direction = variableJoystick.Direction;
    //}
    public void MoveWithJoystick()
    {

    }
 /// <summary>
 /// K
 /// </summary>
 /// <param name="sprite"></param>
    public void ChangeSprite(Sprite sprite)
    {
        if (sprite == null||GameManager.Instance.isMoving)
            return;
        spriteRenderer.sprite = sprite;
    }

}

