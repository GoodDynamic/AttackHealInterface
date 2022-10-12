using UnityEngine;

public class Character : MonoBehaviour
{
    public delegate void HealthChange(float health);

    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    public event HealthChange HealthChanged
    {
        add => _healthChanged += value;
        remove => _healthChanged -= value;
    }

    private event HealthChange _healthChanged;

    private void Start()
    {
        _healthChanged?.Invoke(_health);
    }

    public void AddHealth(float healthPoint)
    {
        _health = _health + healthPoint > _maxHealth ? _maxHealth : _health + healthPoint;
        _healthChanged?.Invoke(_health);
    }

    public void RemoveHealth(float healthPoint)
    {
        _health = _health - healthPoint < _minHealth ? _minHealth : _health - healthPoint;
        _healthChanged?.Invoke(_health);
    }
}
