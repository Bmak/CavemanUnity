using UnityEngine;
using System.Collections;

public class HeroControl : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void Move ()
	{
		var pos = Input.mousePosition;
		Debug.Log (pos);
	}
}	
