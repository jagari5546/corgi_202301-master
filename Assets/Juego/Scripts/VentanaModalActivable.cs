using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentanaModalActivable : MonoBehaviour
{
    [SerializeField]
    private GameObject ventanaModal;
    public GameObject cartel;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(AbrirVentana(1));
        }
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
        ventanaModal.SetActive(false);
        GameManager.Instance.Pause(PauseMethods.NoPauseMenu);
        Destroy(cartel);
        Destroy(ventanaModal);
    }

    IEnumerator AbrirVentana(int sec)
    {
        yield return new WaitForSecondsRealtime(sec);
        ventanaModal.SetActive(true);
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
