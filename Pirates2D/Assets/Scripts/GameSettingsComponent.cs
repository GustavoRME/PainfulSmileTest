
using UnityEngine;

public class GameSettingsComponent : MonoBehaviour
{
    [Range(60.0f, 180f)]
    [SerializeField] private float _gameTime = 60.0f;
    
    [Range(1.0f, 10.0f)]
    [SerializeField] private float _spawnTime = 3.5f;

    public static float GameTime { get; set; } = 60.0f;
    public static float SpawnTime { get; set; } = 3.5f;

    private static bool _isInitialized = false;

    private void Awake()
    {
        if(!_isInitialized)
        {
            GameTime = _gameTime;
            SpawnTime = _spawnTime;
        }

        _isInitialized = true;
    }
}
