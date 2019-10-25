using UnityEngine;
using System.Collections;

public class MouseRotate : MonoBehaviour {
  void update(){
    Vector3 = mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);

    float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);

    transform.rotation = Quaternion.Euler (new Vector3(0f,0f, angle));
  }
  float AngleBetweenPoints (Vector2 a, Vector2 b){
    return Mathf.Antan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
  }
}
