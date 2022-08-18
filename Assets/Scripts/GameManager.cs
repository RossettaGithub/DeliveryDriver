using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]Canvas gameOverScreen;
    [SerializeField]Canvas gameStartScreen;

    [SerializeField]Driver car;

    Timer timer;
AudioSource audioSource;
    void Start()
    {
        timer=GameObject.FindObjectOfType<Timer>();
audioSource = GetComponent<AudioSource>();
        gameOverScreen.gameObject.SetActive(false);
        gameStartScreen.gameObject.SetActive(true);
        car.gameObject.SetActive(false);
    }

   public void GameOver()
   {
        gameOverScreen.gameObject.SetActive(true);
audioSource.Play();
        car.gameObject.SetActive(false);

        timer.SetIsPlaying(false);

   }
public void OnStart()
{
    gameStartScreen.gameObject.SetActive(false);
    car.gameObject.SetActive(true);

    timer.SetIsPlaying(true);
}

public void PlayAgain()
{

    SceneManager.LoadScene(0);

}
}
