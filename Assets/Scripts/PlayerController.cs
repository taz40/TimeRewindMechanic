using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	float speed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = Vector3.zero;
		movement.y += Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		movement.x += Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		transform.Translate (movement);
	}
}
