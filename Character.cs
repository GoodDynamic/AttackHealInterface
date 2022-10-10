using UnityEngine;

[RequireComponent(typeof(CharacterView))]
public class Character : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    private CharacterView _view;

    private void Awake()
    {
        _view = GetComponent<CharacterView>();
        _view.SetHealth(_health);
    }

    public void AddHealth(float healthPoint)
    {
        _health = _health + healthPoint > _maxHealth ? _maxHealth : _health + healthPoint;
        _view.SetHealth(_health);
    }

    public void RemoveHealth(float healthPoint)
    {
        _health = _health - healthPoint < _minHealth ? _minHealth : _health - healthPoint;
        _view.SetHealth(_health);
    }
}
