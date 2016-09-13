using UnityEngine;
using System.Collections;

public class TrapDoorSwitch : MonoBehaviour {

	float rotationSpeed = -2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.T)) {
			
			transform.Rotate (Vector3.forward * rotationSpeed);
		}
	}
}
