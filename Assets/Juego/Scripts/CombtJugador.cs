using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombtJugador : MonoBehaviour
{
    [SerializeField]
    Health health;

    [SerializeField] private float vida;

    public void TomarDa�o(float da�o)
    {
        health.CurrentHealth = vida;
        vida -= da�o;

        if (vida < 0)
        {
            health.DestroyOnDeath = true;
        }




    }
}
