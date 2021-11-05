using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    public bool isSitting = false;
    public bool isRollover = false;
    public bool isSpeaking = false;
    public bool isRunning;
    [SerializeField]  public Animator anim1;



    // Start is called before the first frame update
    void Start()
    {
 
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


        //Set up for animations for walking
        if (Input.GetKey(KeyCode.W))
        {
            anim1.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim1.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim1.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim1.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.C))
        {
            anim1.SetBool("isSitting", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim1.SetBool("isRunning", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim1.SetBool("isRunning", true);
        }
        else
        {
            anim1.SetBool("isSitting", false);
            anim1.SetBool("isRollover", false);
            anim1.SetBool("isSpeaking", false);
            anim1.SetBool("isRunning", false);
        }
    }
}
