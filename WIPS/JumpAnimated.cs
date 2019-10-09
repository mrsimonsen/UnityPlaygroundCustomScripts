using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Jump With Animation")]
[RequireComponent(typeof(Rigidbody2D))]
public class JumpAnimated : Physics2DObject
{
	[Header("Jump setup")]
	// the key used to activate the push
	public KeyCode key = KeyCode.Space;

	// strength of the push
	public float jumpStrength = 10f;

	[Header("Ground setup")]
	//if the object collides with another object tagged as this, it can jump again
	public string groundTag = "Ground";

	//this determines if the script has to check for when the player touches the ground to enable him to jump again
	//if not, the player can jump even while in the air
	public bool checkGround = true;

	private bool canJump = true;
	private bool dJump = false;

	[Header("Animation")]
	public Animator animator;
	public string var = "name of animation parameter";

	// Read the input from the player
	void Update()
	{
		if(canJump
			&& Input.GetKeyDown(key))
		{
			// Apply an instantaneous upwards force
			rigidbody2D.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
			canJump = !checkGround;
			dJump = true;
			animator.SetBool(var, true);
		}
		else if (dJump && Input.getKeyDown(key)){
			rigidbody2D.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impule);
			dJump = false;
			animator.SetBool(var, true);
		}
	}

	private void OnCollisionEnter2D(Collision2D collisionData)
	{
		if(checkGround
			&& collisionData.gameObject.CompareTag(groundTag))
		{
			canJump = true;
			animator.SetBool(var, false);
		}
	}
}
