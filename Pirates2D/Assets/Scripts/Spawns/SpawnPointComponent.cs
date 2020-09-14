using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class SpawnPointComponent : MonoBehaviour
{
    public bool InUse { get; private set; }

    private string _userTag = "";
    private Collider2D _coll2D;

    private void Awake()
    {
        _coll2D = GetComponent<Collider2D>();
        _coll2D.enabled = false;
    }
         

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_userTag))
        {
            InUse = false;
            _coll2D.enabled = false;
        }
    }

    public Vector3 UseSpawn(string tag)
    {
        InUse = true;
        _userTag = tag;

        _coll2D.enabled = true;

        return transform.position;
    }
}
