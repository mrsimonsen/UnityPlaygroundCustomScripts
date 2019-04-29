using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[AddComponentMenu("Playground/Conditions/Create on Death")]
[RequireComponent(typeof(HealthSystemAttribute))]
public class CreateOnDeath : MonoBehaviour
{
	public GameObject prefabToCreate;
	public Vector2 newPosition;
	public bool relativeToThisObject;

	// WARNING: take if from the Project panel, NOT the Scene/Hierarchy!
	// Creates a new GameObject

	private void OnTriggerEnter2D()
	{
		HealthSystemAttribute healthScript = gameObject.GetComponent<HealthSystemAttribute>();
		if(healthScript.health <= 0)
		{
			Create();
		}
	}

	private void Create()
	{
		if(prefabToCreate != null)
		{
			// create the new object by cpying the prefab
			GameObject newObject = Instantiate<GameObject>(prefabToCreate);
			// is the position relative or absolute?
			Vector2 finalPosition = newPosition;
			if (relativeToThisObject)
			{
				finalPosition = (Vector2)transform.position + newPosition;
			}
			//let's place it in the desired position!
			newObject.transform.position = finalPosition;
		}
		else{
			Debug.LogWarning("There is no Prefab assigned to this CreateOnDeath, so a new object can't be created.");
		}
	}
}
