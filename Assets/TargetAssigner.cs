using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Photon.Pun;
using UnityEngine;

public class TargetAssigner : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera followCamera;
    [SerializeField] private PhotonView photonView;
    private void Start()
    {
        if (photonView.IsMine)
        {
            followCamera = FindObjectOfType<CinemachineVirtualCamera>();
            followCamera.Follow = transform;
        }
    }
}
