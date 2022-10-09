using UnityEngine;

[RequireComponent(typeof(CharacterView))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    private CharacterView _view;
    private Character _character;

    private void Awake()
    {
        _view=GetComponent<CharacterView>();
        _character = new Character(_health, _minHealth, _maxHealth);
        _view.SetHealth(_character.Health);
    }

    public void AddHealth(float healthPoint)
    {
        _character.AddHealth(healthPoint);
        _view.SetHealth(_character.Health);
    }

    public void RemoveHealth(float healthPoint)
    {
       _character.RemoveHealth(healthPoint);
        _view.SetHealth(_character.Health);
    }
}
