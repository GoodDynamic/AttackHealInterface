using System;

[Serializable]
public class Character
{
    private float _health;
    private float _maxHealth;
    private float _minHealth;

    public float Health => _health;

    public Character(float health,float minHealth,float maxHealth)
    {
        _health = health;
        _maxHealth = maxHealth;
        _minHealth = minHealth;
    }

    public void AddHealth(float healthPoint)
    {
        _health = _health + healthPoint > _maxHealth ? _maxHealth : _health + healthPoint;
    }

    public void RemoveHealth(float healthPoint)
    {
        _health = _health - healthPoint < _minHealth ? _minHealth : _health - healthPoint;
    }
}
