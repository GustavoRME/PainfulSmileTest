using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowComponent : MonoBehaviour
{
    [SerializeField] private Transform _target = null;

    [Space]
    [SerializeField] private float _smooth = 10.0f;    
    [SerializeField] private Vector3 _offset = new Vector3(0.0f, 0.0f, -10.0f);

    private void FixedUpdate()
    {
        if(_target)
        {
            Vector3 position = _target.position + _offset;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, position, _smooth * Time.fixedDeltaTime);

            transform.position = smoothedPos;
        }
    }
}
