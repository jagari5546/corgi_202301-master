using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.Feedbacks;
using MoreMountains.CorgiEngine;
using System.Diagnostics;

public class Life_Bonues : MonoBehaviour

    
{
    GameManager GHM;

    void Start()
    {
        GHM = FindObjectOfType<GameManager>();
        GHM.GainLives(1);
    }

    public GameObject Extra_Lifes;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GHM.GainLives(1);
            Destroy(gameObject);
        }
    }
}
