using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text leftScore;
    [SerializeField] Text rightScore;
    [SerializeField] Text endGame;

    private int _leftScore;
    private int _rightScore;
    // [SerializeField] EventSystemCustom eventSystemCustom;
    
    // Start is called before the first frame update
    void Start()
    {
        _leftScore = 0;
        _rightScore = 0;
        CustomEventSystem.current.onEndGame.AddListener(UpdateEndGame);
        CustomEventSystem.current.onScoreChange.AddListener(UpdateScore);
        UpdateScore(0);

    }
    private void UpdateScore(int addedScore)
    {

    }
    private void UpdateEndGame()
    {
        endGame.text = "You lose!\nYour Score is ";
    }
}