using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class Monedas : PickableItem
{
    [SerializeField] protected ControlMonedas controlMonedas;


    protected override void Pick(GameObject picker)
    {

        controlMonedas.MonedasRecogidas++;

    }


}