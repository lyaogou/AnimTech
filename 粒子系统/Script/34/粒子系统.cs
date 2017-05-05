using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class 粒子系统 : MonoBehaviour {

		public float _ForcePower = 1.0f;
		public float _ForceOffset = 1.0f;
		public float _LifeSpan = 20.0f;

	private Vector3 direction;
		// Use this for initialization
		void Start () {
		direction = Vector3.zero;
		}

		// Update is called once per frame
		public virtual void Update () {
			LifePassThenDie ();
			ApplyRandomForce ();
		}

		void LifePassThenDie ()//随时间消失
		{
			_LifeSpan -= Time.deltaTime;
			if (_LifeSpan < 0.0f) {
				Destroy (gameObject);
			}
		}

		void ApplyRandomForce ()
		{
		direction = transform.localPosition*0.1f -Vector3 .zero ;
			Rigidbody2D rb = GetComponent<Rigidbody2D> ();
			rb.AddForceAtPosition (_ForcePower * Random.insideUnitCircle, _ForceOffset * Random.insideUnitCircle);//单位圆里的随机点
		rb.AddForceAtPosition (-direction*5.0f,new Vector2(10,0));
		//rb.AddForce (_ForcePower * Random.insideUnitCircle );

		}
}
