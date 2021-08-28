using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcRotation : MonoBehaviour
{
    private Vector3 firstPos;
    private Vector3 secondPos;
    public Vector3 direction;

    public Vector2 CalculateDirection()
    {
        direction = secondPos - firstPos;
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
            {
                return new Vector2(1,0);
            }
            return new Vector2(-1,0);
        }
        if (direction.y > 0)
            return new Vector2(0, 1);
        return new Vector2(0, -1);
    }
    private void OnEnable()
    {
        MobileInput.Instance.onBegin.AddListener(SetFirstPosition);
        MobileInput.Instance.onEnd.AddListener(SetSecondPosition);
    }
    private void OnDisable()
    {
        MobileInput.Instance.onBegin.RemoveListener(SetFirstPosition);
        MobileInput.Instance.onEnd.RemoveListener(SetSecondPosition);
    }
    public void SetFirstPosition(Vector2 pos)
    {
        firstPos = pos;
    }
    public void SetSecondPosition(Vector2 pos)
    {
        secondPos = pos;
    }
}
