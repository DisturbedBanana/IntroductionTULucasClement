using PlasticPipe.PlasticProtocol.Messages;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] EntityHealth _entityHealth;

    private void Start()
    {
        UpdateSlider(_entityHealth.GetCurrentHealth());
        _entityHealth.HealthChanged += UpdateSlider;
    }

    private void OnDestroy()
    {
        _entityHealth.HealthChanged -= UpdateSlider;
    }

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] EntityHealth _playerHealth;

    int CachedMaxHealth { get; set; }

    void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {_entityHealth.GetMaxHealth()}";
    }

    
}
