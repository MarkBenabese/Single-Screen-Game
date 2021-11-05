using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Action : MonoBehaviour
{
    [SerializeField] private Collider playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive;
    [SerializeField] private GameObject player;



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            manager.AddScore(scoreToGive);
        }
    }
}
