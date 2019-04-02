using System;
using System.Collections.Generic;
using UnityEngine;
class PlayerBehavior : MonoBehaviour, IHealth
{
	public float MoveSpeed = 5f;
	public float MaxHealth { get; private set; }
	public float CurrentHealth { get; private set; }

	public void AddHealth(float amount)
	{
		CurrentHealth += amount;
		print(CurrentHealth);
	}

	public void RemoveHealth(float amount)
	{
		CurrentHealth -= amount;
		print(CurrentHealth);
	}

	void Update()
	{
		float x = 0;
		float y = 0;

		if(Input.GetKey(KeyCode.A))
		{
			x -= MoveSpeed;
		}
		if(Input.GetKey(KeyCode.D))
		{
			x += MoveSpeed;
		}

		if(Input.GetKey(KeyCode.W))
		{
			y += MoveSpeed;
		}
		if(Input.GetKey(KeyCode.S))
		{
			y -= MoveSpeed;
		}

		transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0);
	}
}

