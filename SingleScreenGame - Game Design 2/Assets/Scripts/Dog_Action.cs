using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Action : MonoBehaviour
{
    [SerializeField] private Collider playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;
    [SerializeField] private int scoreToGive;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            //transform.position = new Vector3(22.89161f, 4.205579f, -42.29498f);


            manager.AddScore(scoreToGive);

        }
    }
}
