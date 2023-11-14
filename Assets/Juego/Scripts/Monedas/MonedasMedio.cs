using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;


public class MonedasMedio : MonoBehaviour, MMEventListener<PickableItemEvent>
{
    public int contador_monedas;
    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
    public virtual void OnMMEvent(PickableItemEvent item)
    {
        contador_monedas++;
        if (contador_monedas == 15)
        {
            Debug.Log(item);
            GameManager.Instance.GainLives(1);
            contador_monedas = 0;
        }

    }


}
