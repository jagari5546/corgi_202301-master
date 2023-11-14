using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine;

public class button_controler : MonoBehaviour
{
   public void OnLevelEasy1()
    {
        MMSceneLoadingManager.LoadScene("LevelEasy1");
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

   public void OnLevelEasy2()
    {
        MMSceneLoadingManager.LoadScene("LevelEasy2");
    }
    public void OnLevelMedium1()
    {
        MMSceneLoadingManager.LoadScene("LevelMedium1");
    }
    public void OnLevelMedium2()
    {
        MMSceneLoadingManager.LoadScene("LevelMedium2");
    }
    public void OnLevelHard1()
    {
        MMSceneLoadingManager.LoadScene("LevelHard1");
    }
    public void OnLevelHard2()
    {
        MMSceneLoadingManager.LoadScene("Level_2");
    }
    public void OnLevelDificultad()
    {
        MMSceneLoadingManager.LoadScene("Dificultad");
    }
    






}
