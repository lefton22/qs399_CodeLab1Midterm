using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	public float speed = 30f;  // ?how can i set this value on the Inspector?
	//public float OriRoSpeed;

//this rotating speed is the first energy of this world
	public float Speed
	{
		get{ return speed; }
		set { speed = value;}
	} 

    public float timeHere;

	public float radius_currentWheel;

	void Start () 
	{

		//Speed = OriRoSpeed;
	}

	void Update () 
	{
		radius_currentWheel = transform.localScale.x;

		transform.Rotate (0,0, Time.deltaTime * Speed);

////create a time of this wheel
		timeHere = timeHere + Time.deltaTime * Speed;
		//Debug.Log ("TimeHere w1: " + timeHere);
	}


	void OnTriggerEnter2D(Collider2D collision)
	{
		//sDebug.Log ("collide");


	}
}
