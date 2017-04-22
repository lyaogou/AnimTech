using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 空气阻力 : MonoBehaviour {


	private bool allowForce;
	private bool allowForce2;
	private bool allowForce3;
	void Start () {
	}
	void Update () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		if (rb == null) {
			return;
		}
		allowForce = false;
		allowForce2 = false;
		allowForce3 = false;

		if (Input.GetKey(KeyCode.Space))
			allowForce = true;
		Vector3 Force=Vector3. zero;
		Force .y=0.5f;
		if (allowForce)
			rb.AddForce (Force);

		if (Input.GetKey(KeyCode.D))
			allowForce2 = true;
		Vector3 Force2=Vector3. zero;
		Force2 .x=0.5f;
		if (allowForce2)
			rb.AddForce (Force2);
		
		if (Input.GetKey(KeyCode.A))
			allowForce3 = true;
		Vector3 Force3=Vector3. zero;
		Force3 .x=-0.5f;
		if (allowForce3)
			rb.AddForce (Force3);
	}

}
