using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class PlayerHelper : NetworkBehaviour {

    GameHelper _gameHelper;

	// Use this for initialization
	void Start () {
        _gameHelper = GameObject.FindObjectOfType<GameHelper>();

        if(isLocalPlayer){
            _gameHelper.CurrentPlayer = this;
        }

	}

    public void Send(string msg){
        string id = GetComponent<NetworkIdentity>().netId.ToString();
        CmdSend(id, msg);
    }

    [Command]
    public void CmdSend(string id, string msg){
        Debug.Log("Send = " + msg);
        RpcSend(id, msg);
    }

    [ClientRpc]
    public void RpcSend(string id, string msg){
        _gameHelper.textBlock.text += System.Environment.NewLine + id + ": "+ msg;
    }


	// Update is called once per frame
	void Update () {
		
	}
}
