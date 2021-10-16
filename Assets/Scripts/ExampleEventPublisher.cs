using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExampleEventPublisher : MonoBehaviour
{
    public UnityEvent<int> exampleEvent;
    public int exampleNumber = 7;
    
}
