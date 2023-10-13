using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaModal : MonoBehaviour
{
    [SerializeField]
    private GameObject ventana;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AbrirVentana(1));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnContinuar()
    {
        CerrarVentana();
        //StartCoroutine(CerrarVentana(2));
    }

    public void CerrarVentana()
    {
        ventana.SetActive(false);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
    }

    IEnumerator AbrirVentana(int sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        ventana.SetActive(true);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
    }

    IEnumerator CerrarVentana(int sec)
    {
        Debug.Log("Esperar");
        yield return new WaitForSecondsRealtime(sec);
        Debug.Log("Termina espera");
        CerrarVentana();
    }
}
