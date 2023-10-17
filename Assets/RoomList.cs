using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using Unity.Mathematics;
using UnityEngine;

public class RoomList : MonoBehaviourPunCallbacks
{
    public GameObject roomButtonPrefabs;
    public GameObject[] allRooms;
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        for (int i = 0; i < allRooms.Length; i++)
        {
            if (allRooms[i] != null)
            {
                Destroy(allRooms[i]);
            }    
        }

        allRooms = new GameObject[roomList.Count];
        
        for (int i = 0; i < roomList.Count; i++)
        {
            if (roomList[i].IsOpen && roomList[i].IsVisible && roomList[i].PlayerCount >= 1)
            {
                GameObject Room = Instantiate(roomButtonPrefabs, Vector3.zero, quaternion.identity,
                    GameObject.Find("Content").transform);
                Room.GetComponent<Room>().roomName.text = roomList[i].Name;

                allRooms[i] = Room;
            }
        }
    }
}
