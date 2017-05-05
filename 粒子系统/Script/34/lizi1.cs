using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizi1 : 粒子系统 {
	
	//public float _TorquePower = 1.0f;
	public float _LifeSpan1 = 20.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public override void Update () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		//rb.velocity *= 0.99;

		base.Update ();

		_LifeSpan1 -= Time.deltaTime;
	

		Vector3 当前尺寸 = transform.localScale;
		float x方向当前尺寸 = 当前尺寸.x;
		float y方向当前尺寸 = 当前尺寸.y;

		float x尺寸变化极限 = x方向当前尺寸 * 0.01f;
		float y尺寸变化极限 = y方向当前尺寸 * 0.01f;

		float x尺寸随机变化量 = x尺寸变化极限 *_LifeSpan ;
		float y尺寸随机变化量 = y尺寸变化极限 *_LifeSpan;

		Vector3 随机变化后的尺寸 = new Vector3 (
			x方向当前尺寸 - x尺寸随机变化量*0.05f,
			y方向当前尺寸 - y尺寸随机变化量*0.05f);
		
		transform.localScale = 随机变化后的尺寸;
	}

}
