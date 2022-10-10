using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Slider))]
public class CharacterView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _maxStep;

    private float _health;

    public void SetHealth(float health)
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
}
