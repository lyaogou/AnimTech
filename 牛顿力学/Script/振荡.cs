using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 振荡 : MonoBehaviour {
	 float dx;
	float xspacing = 16.0f;
	float[] yvalues;
	int w;float period = 500;
	float theta=0;float amplitude=75;

	private Vector3 移动量;
	private bool allowForce;

	// Use this for initialization
	void Start () {
		w = 1600;
		dx = (float)  (2 * 3.14 / period ) * xspacing;
		yvalues = new float[ (int)(w / xspacing )];
		移动量=Vector3.zero ;
	}
	
	// Update is called once per frame
	void Update () {
		
		theta += 0.02f;
		float x = theta;
		for (int i = 0; i < yvalues.Length; i++) {
			yvalues [i] = Mathf.Sin (x) * amplitude;
		}
		//x += dx;
		//移动量 = transform.localPosition;
		allowForce = false;

		if (Input.GetKey (KeyCode.Space))
			allowForce = true;


		移动量.x = x * xspacing * 0.01f;
		移动量.y = yvalues [(int)x] * 0.1f;
		//移动量.x = 1;
		//移动量.y = 10;
		//if (allowForce) {
			
			transform.Translate (移动量 * 0.001f);

		//}
	}

}
