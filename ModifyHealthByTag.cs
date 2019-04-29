using UnityEngine;
using System.Collections;
using UnityEngine.Events;

[AddComponentMenu("Playground/Attributes/Modify Health By Tag")]
[RequireComponent(typeof(Collider2D))]
public class ModifyHealthByTag : MonoBehaviour
{

	public bool destroyWhenActivated = false;
	public int healthChange = -1;
	public bool filterByTag = false;
	public string filterTag = "Enemy";

	//This will create a dialog window asking for which dialog to add
	private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, true);
	}

	// This function gets called when something touches the object collider
	private void OnCollisionEnter2D(Collision2D collisionData)
	{
		OnTriggerEnter2D(collisionData.collider);
	}

	private void OnTriggerEnter2D(Collider2D colliderData)
	{
		if(colliderData.CompareTag(filterTag) || !filterByTag)
		{
			HealthSystemAttribute healthScript = colliderData.gameObject.GetComponent<HealthSystemAttribute>();
			if(healthScript != null)
			{
				// subtract health from the player
				healthScript.ModifyHealth(healthChange);

				if(destroyWhenActivated)
				{
					Destroy(this.gameObject);
				}
			}
		}
	}
}
