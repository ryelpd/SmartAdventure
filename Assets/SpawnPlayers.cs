using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Photon.Pun;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject player;
    public float minX,minY,minZ,maxX,maxY,maxZ;

    [SerializeField] private CinemachineVirtualCamera cinemachineVirtualCamera;

    public void Start()
    {
        Cursor.visible = false;
        Vector3 spawnPosition =
            new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        var obj = PhotonNetwork.Instantiate(player.name, spawnPosition, Quaternion.identity);
        cinemachineVirtualCamera.Follow = obj.transform.GetChild(0).GetChild(0);
    }
}
