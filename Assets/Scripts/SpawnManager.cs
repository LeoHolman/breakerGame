using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public void Spawn(GameObject obj, Transform point, Transform parent)
    {
        GameObject newspawn = GameObject.Instantiate(obj, point.position, point.rotation);
        newspawn.transform.SetParent(parent);
        newspawn.SetActive(true);
        Debug.Log("Object spawned");
    }
}
