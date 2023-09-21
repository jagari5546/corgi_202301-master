using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;

public class button_controler : MonoBehaviour
{
   public void OnJugar()
    {
        MMSceneLoadingManager.LoadScene("Level_1");
    }

    public void OnInstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

    public void OnCreditos()
    {
        MMSceneLoadingManager.LoadScene("Creditos");
    }

    public void OnMenu()
    {
        MMSceneLoadingManager.LoadScene("Home");
    }

    public void OnPerdiste()
    {
        MMSceneLoadingManager.LoadScene("you_lose");
    }

   public void OnLevel2()
    {
        MMSceneLoadingManager.LoadScene("Level_2");
    }

    public void OnLevel3()
    {
        MMSceneLoadingManager.LoadScene("Level_3");
    }



}
