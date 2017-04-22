using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 引力 : MonoBehaviour {
		//public Transform planet;
		private float forceAmountForRotation = 1f;
		private Vector3 direction;
		private bool allowForce;
	   

		void Start()
		{
			direction = Vector3.zero;
		}

		void Update ()
		{

			allowForce = false;

			if (Input.GetKey(KeyCode.Space))
				allowForce = true;
		

		direction = transform.localPosition -Vector3 .zero ;
			//transform.right = Vector3.Cross(directionOfPlanetFromBird, Vector3.forward);
		//forward是z轴，cross两个向量的交叉相乘，right向x轴

		}
	void FixedUpdate ()
	{
		if (allowForce)
		{GetComponent<Rigidbody2D> ().AddForce (-direction * forceAmountForRotation);
			transform.Translate (-direction*0.1f);}
	}
}
