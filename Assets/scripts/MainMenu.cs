using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public int scene;
    
    public void PlayGame()
    {
        if (scene == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
        else if (scene == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            scene = 2;
        }
        else if (scene == 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            scene = 3;
        }
    }
    public void setDifficulty(string difficulty)
    {
        if (difficulty == "Easy")
        {
            
            scene = 1;
        }
        else if (difficulty == "Medium")
        {
            
            scene = 2;
        }
        else if (difficulty == "Hard")
        {
            
            scene = 3;
        }
    }
    

    public void GoBackEasy()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void GoBackMedium()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        
    }
    public void GoBackHard()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}
