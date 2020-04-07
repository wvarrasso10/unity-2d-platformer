using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restartScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "GameScene")
            SceneManager.LoadScene("GameScene");
        if (scene.name == "MeduimDifficulty")
            SceneManager.LoadScene("MeduimDifficulty");
        if (scene.name == "HardDifficulty")
            SceneManager.LoadScene("HardDifficulty");
    }
}
