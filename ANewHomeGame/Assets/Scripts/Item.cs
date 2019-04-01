using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public abstract class Item : ScriptableObject, IObtainable, IInteractable
{
	[SerializeField] private string id;
	[SerializeField] private string displayName;
	[SerializeField] private string description;

	public string ID { get { return id; } }
	public string DisplayName { get { return displayName; } }
	public string Description { get { return description; } }

	public abstract void PickUp();

	public abstract bool Use(object interactor);
}