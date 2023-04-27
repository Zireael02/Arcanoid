using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lives = 3;

    public Image ball2;
    public Image ball3;

    public void LoseHealth()
    {
        lives--;

        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (lives == 2)
        {
            ResetLevel();
            Destroy(ball3);
        }
        else
        {
            ResetLevel();
            Destroy(ball2);
        }
    }

    public void ResetLevel()
    {
        FindObjectOfType<Ball>().ResetBall();
        FindObjectOfType<Player>().ResetPlayer();
    }

    public void CheckLevelCompleted()
    {
        if (transform.childCount <= 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
