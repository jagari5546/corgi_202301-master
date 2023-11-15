using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombtJugador : MonoBehaviour
{
    [SerializeField]
    Health health;

    [SerializeField] private float vida;

    public void TomarDaño(float daño)
    {
        health.CurrentHealth = vida;
        vida -= daño;

        if (vida < 0)
        {
            health.DestroyOnDeath = true;
        }




    }
}
