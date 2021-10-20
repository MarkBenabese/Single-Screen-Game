using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    public int maxEmotion = 100;
    public int currentEmotion;

    public EmotionBar emotionBar;

    // Start is called before the first frame update
    void Start()
    {
        currentEmotion = 30;
        emotionBar.SetMaxEmotion(maxEmotion);
    }

    // Update is called once per frame
    void Update()
    {
        //Testing inputs to add/subtract from emotion bar
        if (Input.GetKeyDown(KeyCode.Y))
        {
            manager.AddScore(-10);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            manager.AddScore(10);
        } 
    }
}
