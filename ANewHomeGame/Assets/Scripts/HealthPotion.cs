using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/Consumeables/HealthPotion", order = 1)]
public class HealthPotion : Item, IConsumeable
{
	public float HealingAmount;


	public bool Consume(object consumer)
	{
		if(consumer is IHealth)
		{
			(consumer as IHealth).AddHealth(HealingAmount);
			return true;
		}

		return false;
	}

	public override void PickUp()
	{
		
	}

	public override bool Use(object interactor)
	{
		return false;
	}
}