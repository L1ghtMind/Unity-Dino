using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cactus : MonoBehaviour
{
    private GameObject gameOverText;

    private void Awake()
    {

        gameOverText = GameObject.Find("GameOver");
    }

    private void Start()
    {
        if (gameOverText.activeSelf == true)
            gameOverText.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        gameOverText.SetActive(true);
        StartCoroutine(ResetLevel());
    }

    IEnumerator ResetLevel()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
