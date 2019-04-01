using UnityEngine;

public interface IPlaceable
{
	bool PlaceInWorld(object sender, Vector2 coordinates);
}