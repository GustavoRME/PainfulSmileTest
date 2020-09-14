using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreboardComponent : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTextPro = null;

    private void Start()
    {
        if(_scoreTextPro)
        {
            _scoreTextPro.text = "Score " + ScoreManagerComponent.Score;
        }
    }
}
