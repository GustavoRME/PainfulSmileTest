using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManagerComponent : MonoBehaviour
{       
    private SpawnManagerComponent _spawnManger;

    private void Start()
    {
        _spawnManger = FindObjectOfType<SpawnManagerComponent>();
       
        Invoke("LoadLevel", GameSettingsComponent.GameTime);
        InvokeRepeating("SpawnEnemies", GameSettingsComponent.SpawnTime, 1);
    }
       
    private void SpawnEnemies() => _spawnManger.SpawnEnemies();
    private void LoadLevel() => SceneManager.LoadScene(2);
    
    public void LoadLevelWhenDie(float time)
    {
        CancelInvoke();
        Invoke("LoadLevel", time);
    }
}
