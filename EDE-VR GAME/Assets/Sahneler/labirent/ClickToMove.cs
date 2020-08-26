using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour {
		public Transform vrCamera;
		public float speed = 3.0f;
		public bool moveForward;
		public bool moveBackward;
		private CharacterController cc;

		// Use this for initialization
		void Start()
		{
			cc = GetComponent<CharacterController>();
		}

		// Update is called once per frame
		void Update ()
	{
		if (Input.GetButton ("Fire1")) {
			moveForward = true;
		} else {
			moveForward = false;
		}

		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);

			cc.SimpleMove (forward * speed);
		}
	}
}