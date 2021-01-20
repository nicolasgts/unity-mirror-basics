using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    // virtual methods in mirror means that we can override that methods to make our own behavior

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        
        Debug.Log("I connected to a server");
    }

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        
        Debug.Log("The player was add in the server");
        Debug.Log($"There is {numPlayers} connected in the server");
    }
}
