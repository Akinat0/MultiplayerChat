using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameHelper : MonoBehaviour
{

    public InputField inputField;
    public Text textBlock;

    private PlayerHelper _currentPlayer;

    public PlayerHelper CurrentPlayer
    {
        get {return _currentPlayer;}

        set { _currentPlayer = value;}
    }

	// Use this for initialization
	void Start () {
		
	}

    public void Send(){
        CurrentPlayer.Send(inputField.text);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
