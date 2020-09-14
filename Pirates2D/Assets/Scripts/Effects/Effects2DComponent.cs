using System.Collections;
using UnityEngine;

public class Effects2DComponent : MonoBehaviour
{
    public enum EffectType 
    { 
        Explosion = 0, 
        StickFigures = 1
    }

    public EffectType effect = EffectType.Explosion;

    public float lifeTime;
    public float fadeOutTime;
    public float throwForce;    
    public float gravityTime;
    
    public bool useRandomDirection;
    public bool useFadeOutToDisable;
    
    public SpriteRenderer[] stickFiguresRenderers;
    public Rigidbody2D rb2D;
    public Vector2 direction;

    private float _currentFadeOut;        

    private void OnEnable()
    {
        _currentFadeOut = fadeOutTime;
        
        CancelInvoke();        
    }

    public void StartEffect(Vector3 position)
    {
        if(effect == EffectType.Explosion)
        {
            Explosion(position);
        }
        else
        {
            StickFigures(position);
        }
        
        DisableController();
    }

    private void Explosion(Vector3 position)
    {        
        transform.position = position;
        Enable();
    }
    private void StickFigures(Vector3 position)
    {
        rb2D.bodyType = RigidbodyType2D.Dynamic;
        rb2D.simulated = true;
        
        transform.position = position;
        Vector2 force;

        if(useRandomDirection)
        {
            force = Random.insideUnitCircle * throwForce;
        }
        else
        {
            force = direction * throwForce;
        }
                
        Enable();
        rb2D.AddForce(force);
        Invoke("SetStaticBodyType", gravityTime);
    }
    private void DisableController()
    {
        if(useFadeOutToDisable)
        {
            if(stickFiguresRenderers != null)
                StartCoroutine(FadeOut());
            else
                Invoke("Disable", lifeTime);
        }
        else
        {
            Invoke("Disable", lifeTime);
        }
    }
    private IEnumerator FadeOut()
    {
        while(_currentFadeOut > 0.0f)
        {
            foreach (SpriteRenderer rend2D in stickFiguresRenderers)
            {
                Color color = rend2D.color;

                color.a = _currentFadeOut / 1.0f;

                rend2D.color = color;                
            }

            _currentFadeOut -= Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        Disable();
    }
    private void Disable() => gameObject.SetActive(false);
    private void Enable() => gameObject.SetActive(true);
    private void SetStaticBodyType() => rb2D.bodyType = RigidbodyType2D.Static;
}
