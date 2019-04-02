using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory
{
	private GameObject player;

	// Start is called before the first frame update
	void Start()
    {
		player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public IObtainable AddItem(IObtainable item, int index)
	{
		throw new System.NotImplementedException();
	}

	public IObtainable AddItem(IObtainable item)
	{
		throw new System.NotImplementedException();
	}

	public IObtainable RemoveItem(int index)
	{
		throw new System.NotImplementedException();
	}
}
