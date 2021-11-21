using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyIntEvent : UnityEvent<int,int> {}
[System.Serializable]

public class CustomEventSystem : MonoBehaviour
{
    public static CustomEventSystem current;
    public MyIntEvent onScoreChange;
    public UnityEvent onEndGame;

    void Awake()
    {
        current = this;
        onScoreChange = new MyIntEvent();
        onEndGame = new UnityEvent();
    }
}