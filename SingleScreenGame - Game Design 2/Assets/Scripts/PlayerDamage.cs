using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private Collider playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            transform.position = new Vector3(114.236f, 4.783f, 44.041f);

            
            manager.AddScore(-scoreToGive);

        }
        if (other.gameObject.tag == "NPC")
        {

            //transform.position = new Vector3(22.8916f, 4.205579f, -42.29498f);


            manager.AddScore(scoreToGive);

        }
    }
}
