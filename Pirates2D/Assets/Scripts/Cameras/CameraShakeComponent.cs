using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeComponent : MonoBehaviour
{
    [SerializeField] private float _time = 1.0f;
    [SerializeField] private float _strength = 10.0f;

    private float _elapsedTime;

    public void ShakeCamera() => StartCoroutine(Shake());

    private IEnumerator Shake()
    {
        _elapsedTime = _time;

        while(_elapsedTime > 0.0f)
        {
            transform.position += (Vector3)Random.insideUnitCircle * _strength;
            _elapsedTime -= Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }                
    }
}
