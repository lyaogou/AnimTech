﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lizi2 : 粒子系统 {
	public float _LifeSpan1 = 20.0f;
	float _速率系数 = 1.0f;
	Vector2 _噪声速率;
	Vector2 _噪声起点;
	float _基准值= 0.3f,_最大偏移= 0.1f;
	// Use this for initialization
	void Start () {
		_噪声速率 = Random.insideUnitCircle;
		_噪声起点 = Random.insideUnitCircle * 100.0f;
	}
	
	// Update is called once per frame
	public override void Update () {
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		//rb.velocity *= 0.99;

		base.Update ();

		_LifeSpan1 -= Time.deltaTime;

		float 时刻 = Time.realtimeSinceStartup;
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Color 当前颜色 = sr.color;

		float 透明度 = 当前颜色.a;
		透明度 = Mathf.PerlinNoise (
			_噪声速率.x * 时刻, _噪声速率.y * 时刻);
		透明度 = AT_MathUtil.map (
			透明度, 
			0.0f,1.0f,
			_基准值 - _最大偏移, 
			_基准值 + _最大偏移);
		当前颜色.a = 透明度;

		sr.color = 当前颜色;
	}
		
	[ContextMenu("以当前透明度作为基准")]
	public void 以当前透明度作为基准()
	{
		_基准值 = GetComponent<SpriteRenderer> ().color.a;
	}

	[ContextMenu("初始化噪声参数")]
	public void 初始化噪声参数()
	{
		_噪声速率 = Random.insideUnitCircle * _速率系数;
		_噪声起点 = Random.insideUnitCircle * 100.0f;
	}
}
