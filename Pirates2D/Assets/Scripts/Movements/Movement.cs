using UnityEngine;

public class Movement
{
    private readonly Rigidbody2D _rb2D;
    private readonly Transform _pawn;

    public Movement(Transform pawn, Rigidbody2D rigibody2D)
    {
        _pawn = pawn;
        _rb2D = rigibody2D;

        _rb2D.freezeRotation = true;
    }

    public void MoveForward(Vector2 direction, float speed)
    {
        if(_rb2D)
        {
            Vector2 moveTo = (Vector2)_pawn.position + (direction.normalized * speed * Time.deltaTime);

            _rb2D.MovePosition(moveTo);
        }
    }        
    public void Rotate(float angle)
    {
        if(_rb2D)
        {
            _rb2D.rotation = angle;
        }
    }
    public void RotatePlus(float angle, float speed)
    {
        if(_rb2D)
        {
            _rb2D.rotation += angle * speed * Time.deltaTime;
        }
    }    
    public void FreezeRigidbody()
    {
        _rb2D.freezeRotation = true;
        _rb2D.velocity = Vector2.zero;

    }
    public void UnfreezeRigidBody()
    {
        _rb2D.freezeRotation = false;        
    }    
}
