using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PoolManagerComponent : MonoBehaviour
{    
    [Serializable]
    private class Pooler
    {
        public GameObject prefab = null;
        public int poolSize = 0;
    }

    [SerializeField] private Pooler[] _prefabs = null;

    private Dictionary<GameObject, Queue<GameObject>> _pool;

    private void Awake()
    {
        _pool = new Dictionary<GameObject, Queue<GameObject>>();

        foreach (var p in _prefabs)
        {
            Queue<GameObject> queue = new Queue<GameObject>();

            for (int i = 0; i < p.poolSize; i++)
            {
                GameObject obj = Instantiate(p.prefab, transform);
                
                obj.SetActive(false);

                queue.Enqueue(obj);
            }

            _pool[p.prefab] = queue;
        }
    }

    public T GetComponentFromPool<T>(GameObject key) where T : UnityEngine.Object
    {        
        if(_pool.TryGetValue(key, out Queue<GameObject> queue))
        {
            GameObject obj;

            if(queue.Count > 0)
            {
                obj = queue.Dequeue();
            }
            else
            {
                obj = Instantiate(key, transform);
            }

            queue.Enqueue(obj);

            return obj.GetComponent<T>();
        }

        return null;
    }
}
