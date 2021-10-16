using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public string name;
    public EventInvoker events;
    // Start is called before the first frame update
    void Start()
    {
        this.name = "Player";
        events = events ?? GameObject.Find("EventInvoker").GetComponent<EventInvoker>();
        events.GetEvent(0).AddListener(Spawn);
    }

    // Update is called once per frame
    void Update()
    {
        events?.Invoke(0);
    }

    public void Spawn()
    {
        Debug.Log("Spawn called");
        events = null;
    }
}
