using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject player;
    public SpawnManager spawnManager;
    public Transform spawnPoint;
    public Transform spawnParent;

    public void Spawn()
    {
        spawnManager.Spawn(player, spawnPoint, spawnParent);
    }
}
