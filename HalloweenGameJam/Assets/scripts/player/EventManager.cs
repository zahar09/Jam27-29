using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action ChangeState;

    public static void OnChangeState()
    {
        ChangeState?.Invoke();
    }
}
