using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventInvoker : MonoBehaviour
{
    [SerializeField]
    private LifeCycleEvent roundStarted = new LifeCycleEvent("RoundStarted");
    [SerializeField]
    private List<UnityEvent> events;

    private void Awake()
    {
        events = events ?? new List<UnityEvent>();
        events.Add(roundStarted);
        // events.Add(new LifeCycleEvent("RoundStarted"));
        // events.Add(new LifeCycleEvent("RoundEnded"));
    }

    private void Start()
    {
        this.roundStarted.Invoke();
    }

    public void Invoke(int index)
    {
        Debug.Log(((LifeCycleEvent)events[index]).name + " invoked");
        events[index]?.Invoke();
    }

    public UnityEvent GetEvent(int index)
    {
        return events[index];
    }
}
