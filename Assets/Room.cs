using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Room : MonoBehaviour
{
    public TMP_Text roomName;

    public void JoinRoom()
    {
        GameObject.Find("RoomManager").GetComponent<RoomManager>().JoinRoomInList(roomName.text);
    }
}
