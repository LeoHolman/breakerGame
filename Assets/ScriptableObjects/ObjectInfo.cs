using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object Info", menuName = "ScriptableObjects/ObjectInfo", order = 1)]
public class ObjectInfo : ScriptableObject
{
    public string objectName = "new object";
    public int value = 1;

}
