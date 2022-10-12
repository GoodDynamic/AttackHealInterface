using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(Character))]
public class HealthbarView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _maxStep;

    private Character _character;
    private float _health;

    private void Awake()
    {
        _character = GetComponent<Character>();
        _character.HealthChanged += SetHealth;
    }

    private void SetHealth(float health)
    {
        _health = health;
        StartCoroutine(ChangeHealthBar());
    }

    private IEnumerator ChangeHealthBar()
    {
        while (_slider.value!=_health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health, _maxStep);
            yield return null;
        }
    }

    private void OnDisable()
    {
        _character.HealthChanged -= SetHealth;
    }
}
