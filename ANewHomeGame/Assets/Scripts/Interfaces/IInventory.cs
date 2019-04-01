using System;
using System.Collections;
using UnityEngine;

public interface IInventory
{
	IObtainable AddItem(IObtainable item, int index);
	IObtainable AddItem(IObtainable item);
	IObtainable RemoveItem(int index);
}
