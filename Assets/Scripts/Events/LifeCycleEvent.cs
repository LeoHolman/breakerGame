using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class LifeCycleEvent : UnityEvent
{
    public string name;
    public LifeCycleEvent() : base() {
        this.name = "LifeCycleEvent";
    }

    public LifeCycleEvent(string name) : base() {
        this.name = name;
    }
}
