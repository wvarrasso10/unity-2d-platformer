using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (col.gameObject.tag.Equals("Player"))
        {
            
            if (scene.name == "GameScene")
            {
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            }
            else if (scene.name == "MeduimDifficulty")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
            else if (scene.name == "HardDifficulty")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
