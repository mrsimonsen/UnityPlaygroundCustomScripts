using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

[AddComponentMenu("Playground/Conditions/Condition 2 Key Press")]
public class Condition2KeyPress : ConditionBase
{
	public KeyCode keyToPress1 = KeyCode.Space;
	public KeyCode keyToPress2 = KeyCode.LeftControl;

	[Header("Type of Event")]
	public KeyEventTypes eventType = KeyEventTypes.JustPressed;

	public float frequency = 0.5f;

	private float timeLastEventFired;




	private void Start()
	{
		timeLastEventFired = -frequency;
	}




	private void Update()
	{
		switch(eventType)
		{
			case KeyEventTypes.JustPressed:
				if(Input.GetKeyDown(keyToPress1) && Input.GetKeyDown(keyToPress2))
				{
					ExecuteAllActions(null);
				}
				break;
			case KeyEventTypes.Released:
				if(Input.GetKeyUp(keyToPress1) && Input.GetKeyUp(keyToPress2))
				{
					ExecuteAllActions(null);
				}
				break;
			case KeyEventTypes.KeptPressed:
				if(Time.time >= timeLastEventFired + frequency
					&& Input.GetKey(keyToPress1) && Input.GetKey(keyToPress2))
				{
					ExecuteAllActions(null);
					timeLastEventFired = Time.time;
				}
				break;
		}
	}




	public enum KeyEventTypes
	{
		JustPressed,
		Released,
		KeptPressed
	}



}
