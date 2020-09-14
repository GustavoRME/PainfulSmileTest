using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManagerComponent : MonoBehaviour
{
    [SerializeField] private int _pointsForDeath = 1;

    public static int Score { get; private set; } = 0;

    private void Start() => Score = 0;        
    public void IncreaseScore() => Score += _pointsForDeath;    
}
