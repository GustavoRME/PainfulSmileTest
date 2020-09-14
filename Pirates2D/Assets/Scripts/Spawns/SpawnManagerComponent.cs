using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerComponent : MonoBehaviour
{
    private const int MAX_WHILES = 10;

    [SerializeField] private int _amountEnemiesToSpawn = 3;
    [SerializeField] private PoolManagerComponent _poolManager = null;

    [Space]
    [SerializeField] private GameObject[] _enemiesForSpawn = null;
    [SerializeField] private SpawnPointComponent[] _spawnPoints = null;                

    public void SpawnEnemies()
    {       
        if(_enemiesForSpawn.Length > 0  && _spawnPoints.Length > 0 )
        {
            int whilesCount = 0;

            for (int i = 0; i < _amountEnemiesToSpawn; i++)
            {
                int indexSpawn = Random.Range(0, _spawnPoints.Length);
                int indexEnemy = Random.Range(0, _enemiesForSpawn.Length);

                while (_spawnPoints[indexSpawn].InUse)
                {
                    indexSpawn = Random.Range(0, _spawnPoints.Length);

                    if (whilesCount >= MAX_WHILES)
                    {
                        return;
                    }
                    
                    whilesCount++;
                }

                Transform enemy = _poolManager.GetComponentFromPool<Transform>(_enemiesForSpawn[indexEnemy]);
                
                if(enemy)
                {
                    if(!enemy.gameObject.activeSelf)
                    {
                        enemy.position = _spawnPoints[indexSpawn].UseSpawn(enemy.tag);
                        enemy.gameObject.SetActive(true);                    
                    }
                }
            }            
        }     
        
    }    
}
