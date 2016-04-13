﻿using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {
		
	[SerializeField]
	private float _feetRadius;

	[SerializeField]
	private Transform _transform;

	[SerializeField]
	private float _distanceTrigger;

	[SerializeField]
	private float _jumpSpeed;

	[SerializeField]
	private Rigidbody _rigidbody;

	private bool _canJump = true;

	private RaycastHit _hit;

	void FixedUpdate () {
		if (!_canJump && Input.GetAxis("Jump") == 0)
			_canJump = true;

		if (_canJump && Input.GetAxis("Jump") > 0 && Physics.SphereCast(_transform.position + Vector3.up * _feetRadius * 1.1f, _feetRadius, Vector3.down, out _hit, 0.1f))
		{
			_rigidbody.AddForce(Vector3.up * _jumpSpeed, ForceMode.VelocityChange);
			_canJump = false;
		}
	}
}
