using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playerscore = 0;
    public Text scoreText; // Para usar (Text) que no es parte de los basicos de Unity, agregamos la libreria de UI
    public GameObject GameOverscreen;

    [ContextMenu("Score +1")]
    public void addscore(int scoreToAdd)
    {
        playerscore = playerscore + scoreToAdd;
        scoreText.text = playerscore.ToString(); //playerscore es un int y scoretext es un string, para hacerlos 
                                                 //compatibles se usa ToString
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
        GameOverscreen.SetActive(true);
    }
}
