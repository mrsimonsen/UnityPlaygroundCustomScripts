using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Move With Animation")]
[RequireComponent(typeof(Rigidbody2D))]
public class MoveAnimated : Physics2DObject
{
	[Header("Input keys")]
	public Enums.KeyGroups typeOfControl = Enums.KeyGroups.ArrowKeys;

	[Header("Movement")]
	[Tooltip("Speed of movement")]
	public float speed = 5f;
	public Enums.MovementType movementType = Enums.MovementType.AllDirections;

	[Header("Orientation")]
	public bool orientToDirection = false;
	// The direction that will face the player
	public Enums.Directions lookDirection = Enums.Directions.Up;

	public bool constrainFlip = false;
	public Enums.Axes constrainAxis = Enums.Axes.X;

	private Vector2 movement, cachedDirection;
	private float moveHorizontal;
	private float moveVertical;


	[Header("Animation")]
	public Animator animator;
	public string var = "name of animation parameter";
	// Update gets called every frame
	void Update ()
	{
		animator.SetFloat(var,Mathf.Abs(moveHorizontal)+Mathf.Abs(moveVertical));
		// Moving with the arrow keys
		if(typeOfControl == Enums.KeyGroups.ArrowKeys)
		{
			moveHorizontal = Input.GetAxis("Horizontal");
			moveVertical = Input.GetAxis("Vertical");
		}
		else
		{
			moveHorizontal = Input.GetAxis("Horizontal2");
			moveVertical = Input.GetAxis("Vertical2");
		}

		//zero-out the axes that are not needed, if the movement is constrained
		switch(movementType)
		{
			case Enums.MovementType.OnlyHorizontal:
				moveVertical = 0f;
				break;
			case Enums.MovementType.OnlyVertical:
				moveHorizontal = 0f;
				break;
		}

		movement = new Vector2(moveHorizontal, moveVertical);


		//rotate the GameObject towards the direction of movement
		//the axis to look can be decided with the "axis" variable
		if(orientToDirection)
		{
			if(constrainFlip){
				if (constrainAxis == Enums.Axes.X){
					if(Mathf.Abs(movement.y) >= 0.01f){
						cachedDirection = new Vector2(0f, movement.y);
					}
				}
				else{
					if(Mathf.Abs(movement.x) >= 0.01f){
						cachedDirection = new Vector2(movement.x, 0f);
					}
				}
			}
			else if(movement.sqrMagnitude >= 0.01f)
			{
				cachedDirection = movement;
			}
			Utils.SetAxisTowards(lookDirection, transform, cachedDirection);
		}
	}



	// FixedUpdate is called every frame when the physics are calculated
	void FixedUpdate ()
	{
		// Apply the force to the Rigidbody2d
		rigidbody2D.AddForce(movement * speed * 10f);
	}
}
