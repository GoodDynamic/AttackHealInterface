using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class CharacterView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _maxStep;

    private float _health;

    public void SetHealth(float health)
    {
        _health = health;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health, _maxStep);
    }
}
