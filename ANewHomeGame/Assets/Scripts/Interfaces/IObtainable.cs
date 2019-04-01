
public interface IObtainable
{
	string ID { get; }
	string DisplayName { get; }
	string Description { get; }
	void PickUp();
}