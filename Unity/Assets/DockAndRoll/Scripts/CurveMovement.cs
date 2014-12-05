﻿using UnityEngine;
using System.Collections;

public class CurveMovement : MonoBehaviour
{
	public AnimationCurve curve;
	public Vector3 scale = new Vector3(0, 1, 0);
	public float minChange = 0;
	public float maxChange = 3f;
	public float timeOffset = 0f;
	public float speed = 1f;
	
	private Vector3 baseVector;
	private float timer = 0f;
	
	void Start()
	{
		baseVector = transform.position;
	}
	
	// Update is called once per frame
	void Update()
	{
		float value = curve.Evaluate(timer + timeOffset);
		value *= maxChange - minChange;
		value += minChange;
		transform.position = baseVector + scale * value;
		
		timer += Time.deltaTime * speed;
	}
}
