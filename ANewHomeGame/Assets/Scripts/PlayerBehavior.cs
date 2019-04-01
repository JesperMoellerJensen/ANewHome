using System;
using System.Collections.Generic;
using UnityEngine;
class PlayerBehavior : MonoBehaviour, IHealth
{
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
}

