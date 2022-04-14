using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]Canvas gameOverScreen;
    [SerializeField]Driver car;
    void Start()
    {
        gameOverScreen.gameObject.SetActive(false);
    }

   public void GameOver()
   {
        gameOverScreen.gameObject.SetActive(true);

        car.gameObject.SetActive(false);
   }

public void PlayAgain()
{

    SceneManager.LoadScene(0);

}
}
