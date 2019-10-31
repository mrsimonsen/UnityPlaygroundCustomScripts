using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Crouch With Animation")]
[RequireComponent(typeof(Rigidbody2D))]
public class CrouchAnimated : Physics2DObject
{
	[Header("Crouch setup")]
	// the key used to activate the push
	public KeyCode key = KeyCode.Space;

	[Header("Animation")]
	public Animator animator;
	public string var = "name of animation parameter";

	// Read the input from the player
	void Update()
	{
		if(Input.GetKeyDown(key))
		{
			// Apply an instantaneous upwards force
			animator.SetBool(var, true);
		}
	}
}
