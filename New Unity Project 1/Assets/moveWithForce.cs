using UnityEngine;
using System.Collections;

public class moveWithForce : MonoBehaviour {

	float acceleration = 30;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ().AddForce (Vector3.left * Input.GetAxis ("Horizontal") * acceleration );
		GetComponent<Rigidbody> ().AddForce (Vector3.up * Input.GetAxis ("Vertical") * acceleration );



	}
}
