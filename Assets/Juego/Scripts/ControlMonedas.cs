using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMonedas : MonoBehaviour
{
    [SerializeField] int monedas = 0;
    [SerializeField] GameObject Activable;
    GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    public int MonedasRecogidas
    {
        get { return monedas; }
        set { monedas = value; }
    }
    // Update is called once per frame
    void Update()
    {
        if (monedas != 0)
        {
            cantidadMonedas();
        }
        if (monedas == 3)
        {
            monedasRecogidas();
            monedas++;
        }
    }

    public void monedasRecogidas()
    {
        Activable.SetActive(true);
        gameManager.AddLives(1, true);
        //gameManager.AddLives(0, false);
    }
    public void cantidadMonedas()
    {
        Debug.Log(monedas);
    }

}