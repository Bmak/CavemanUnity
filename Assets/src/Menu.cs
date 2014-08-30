using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using AssemblyCSharp;

public class Menu : MonoBehaviour 
{
	public Text Name;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void LoadLevel() 
	{
		if (Name != null) 
		{
			Debug.Log("CHECK");
			Debug.Log(Name.text);
			Settings.PLAYER_NAME = Name.text;
		}
		Debug.Log("welcome " + Settings.PLAYER_NAME.ToString());
		Settings.GAME_TYPE = 0;
		Application.LoadLevel (1);
	}
}
