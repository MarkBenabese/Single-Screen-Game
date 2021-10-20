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
            
            transform.position = new Vector3(13.1f,1.3f,-42.71464f);

            transform.position = new Vector3(0f,0f,0f);
            manager.AddScore(scoreToGive);

        }
    }
}
