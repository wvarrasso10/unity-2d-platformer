using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyDropdown : MonoBehaviour
{
    
    public string difficulty;
    public Dropdown dropdown;
    public MainMenu mainmenu;
    // Start is called before the first frame update
    void Start()
    {
        populateData();

    }
    void Update()
    {
        difficulty = dropdown.options[dropdown.value].text;
        mainmenu = GameObject.FindObjectOfType<MainMenu>();
        mainmenu.setDifficulty(difficulty);

    }
    void populateData()
    {
        List<string> difficultyOptions = new List<string>() {"Easy", "Medium", "Hard"};
        dropdown.AddOptions(difficultyOptions);
    }
}
