using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExampleBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ExampleEventPublisher publisher = gameObject.GetComponent<ExampleEventPublisher>();
        var publisher = gameObject.GetComponent<ExampleEventPublisher>();
        raiseEvent(publisher.exampleEvent, publisher.exampleNumber);

        
    }
     public void raiseEvent(UnityEvent<int> exampleEvent, int exampleNumber)
    {
        exampleEvent.Invoke(exampleNumber);
    }
}
