using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBarComponent : MonoBehaviour
{
    [SerializeField] private Slider _healthBar = null;
    [SerializeField] private Image _background = null;
    [SerializeField] private GameObject _fillArea = null;

    [Space]
    [SerializeField] private float _fadeOutHealthBarTime = 1.0f;

    private float _fadeOutTime;

    public void StartHealth(int health)
    {
        if(_healthBar)
        {
            _healthBar.maxValue = health;
            _healthBar.minValue = 0.0f;
            _healthBar.value = health;

            _fadeOutTime = _fadeOutHealthBarTime;
        }
    }
    public void UpdateHealth(int health)
    {
        if(_healthBar)
        {
            _healthBar.value = health;                         
        }
    }    
    public void HealthBarOver()
    {
        _fillArea.SetActive(false);
        StartCoroutine(FadeOutBackground());
    }

    private IEnumerator FadeOutBackground()
    {
        Color currentColor = _background.color;

        while(_fadeOutTime > 0.0f)
        {
            currentColor.a = _fadeOutTime / 1.0f;            

            _background.color = currentColor;

            _fadeOutTime -= Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
    }
}
