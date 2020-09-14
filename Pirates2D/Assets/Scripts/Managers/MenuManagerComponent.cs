using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerComponent : MonoBehaviour
{
    [SerializeField] private GameObject _optionsMenu = null;
    [SerializeField] private SliderTextComponent _gameSeasion = null;
    [SerializeField] private SliderTextComponent _spawnTime = null;
    
    private bool _isloadingLevel;

    private void Start() => _isloadingLevel = false;

    public void LoadMainScene()
    {
        if(!_isloadingLevel)
            SceneManager.LoadScene(1);

        _isloadingLevel = true;
    }
    public void LoadMainMenu()
    {
        if (!_isloadingLevel)
            SceneManager.LoadScene(0);

        _isloadingLevel = true;
    }
    public void OpenOptions()
    {
        if(_optionsMenu)
        {
            if (!_optionsMenu.activeSelf)
                _optionsMenu.SetActive(true);
        }
    }
    public void CloseOptions()
    {
        if(_optionsMenu)
        {
            if (_optionsMenu.activeSelf)
                _optionsMenu.SetActive(false);
        }
    }
}
