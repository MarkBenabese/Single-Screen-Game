using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private GameObject player;
    [SerializeField] private UnityEvent<string> addScore;
    private int emotion;
    public int maxEmotion = 100;
    public int currentEmotion;
    public EmotionBar emotionBar;
    
    private void Start()
    {
        currentEmotion = 25;
        //PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    
    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }
    
    public void AddScore(int emotionAmt)
    {
        currentEmotion += emotionAmt;
        emotionBar.SetEmotion(currentEmotion);
    }
    
    
}
