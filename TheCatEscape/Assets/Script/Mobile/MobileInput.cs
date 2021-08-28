using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MobileInput : MonoBehaviour
{
   public static MobileInput Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }
    public VariableJoystick variableJoystick;
    public UnityEvent<Vector2> onBegin;
    public UnityEvent<Vector2> onEnd;
    /// <summary>
    /// Ekrana dokunulduğu anda çalışır.
    /// </summary>
    /// <param name="touchPos">dokunulan alan pozisyonu</param>
    public void InvokeBegin(Vector2 touchPos)
    {
        onBegin?.Invoke(touchPos);
    }
    /// <summary>
    /// Ekrandan parmak kaldırıldığı anda çalışır.
    /// </summary>
    /// <param name="touchPos"></param>
    public void InvokeEnd(Vector2 touchPos)
    {
        onEnd?.Invoke(touchPos);
    }
   
}
