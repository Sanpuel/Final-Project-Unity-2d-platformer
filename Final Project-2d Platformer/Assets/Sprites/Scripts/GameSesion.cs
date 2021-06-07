using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSesion : MonoBehaviour
{

    [SerializeField] int playerLives = 6;
    [SerializeField] int score = 0;

    [SerializeField] Text livesText;
    

    private void Awake()
    {
        int numbGameSession = FindObjectsOfType<GameSesion>().Length;
        if (numbGameSession > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = playerLives.ToString();
    }


    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }

    private void TakeLife()
    {
        playerLives--;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        livesText.text = playerLives.ToString();

    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}
