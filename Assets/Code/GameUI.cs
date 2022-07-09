using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI: MonoBehaviour
{
  public void NextOrder(){
        SceneManager.LoadScene("MainMenu");
    }

  public void QuitGame(){
        Application.Quit();
    }
}
