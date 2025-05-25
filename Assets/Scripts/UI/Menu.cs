using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void ActivateLevelScene()
  {
    SceneManager.LoadScene(1);
  }
  public void ActivateInfinityScene()
  {
    SceneManager.LoadScene(2);
  }
}
