using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderTextComponent : MonoBehaviour
{
    private enum SettingsType { SpawnTime, GameTime};
    
    [SerializeField] private SettingsType _settings = SettingsType.SpawnTime;

    [Space]
    [SerializeField] private Slider _slider = null;
    [SerializeField] private TextMeshProUGUI _valueTextPro = null;
    [SerializeField] private string _suffix = "";

    private void Start()
    {
        if (_slider && _valueTextPro)
        {
            if (_settings == SettingsType.SpawnTime)
            {
                float spawnTime = GameSettingsComponent.SpawnTime;
                
                _slider.value = spawnTime;
                WriteInSeconds(spawnTime);
            }
            else
            {
                float gameTime = GameSettingsComponent.GameTime;

                _slider.value = gameTime / 60.0f;
                WriteInMinutes(gameTime);
            }
        }
    }    
    public void WriteValue(float secondsValue)
    {
        if (_settings == SettingsType.SpawnTime)
        {            
            WriteInSeconds(secondsValue);
            GameSettingsComponent.SpawnTime = secondsValue;
        }
        else
        {            
            WriteInMinutes(secondsValue);
            GameSettingsComponent.GameTime = secondsValue;
        }
    }

    private void WriteInSeconds(float seconds) => _valueTextPro.text = seconds.ToString("F1") + " " + _suffix;
    private void WriteInMinutes(float seconds) => _valueTextPro.text = (seconds / 60.0f).ToString("F0") + " " + _suffix;
}
