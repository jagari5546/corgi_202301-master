using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    [SerializeField] Health health;


    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMaxima()
    {
        float vidaMaxima = health.MaximumHealth;
        slider.maxValue = vidaMaxima;
    }

    public void CambiarVidaActual()
    {
        float cantidadVida = health.CurrentHealth;
        slider.value = cantidadVida;
    }

    public void InicializarBarraDeVida()
    {
        CambiarVidaMaxima();
        CambiarVidaActual();

    }
    

}
