public interface IHealth
{
	float MaxHealth { get; }
	float CurrentHealth { get; }
	void AddHealth(float amount);
	void RemoveHealth(float amount);
}