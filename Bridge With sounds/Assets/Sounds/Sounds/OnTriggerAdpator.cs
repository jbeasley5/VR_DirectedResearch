using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerAdpator : MonoBehaviour {

	public UnityEvent whenTriggerEnter;
	public UnityEvent whenTriggerExit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("ENTERED TRIGGER AREA");
		whenTriggerEnter.Invoke ();
	}
	void OnTriggerExit(Collider other)
	{
		Debug.Log ("EXITED TRIGGER AREA");
		whenTriggerExit.Invoke ();
	}
}
