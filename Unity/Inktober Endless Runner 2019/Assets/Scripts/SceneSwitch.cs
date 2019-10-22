using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Goes to title screen
    public void GotoTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    //Go to credits
    public void GotoCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    //Go to game
    public void GotoGame()
    {
        SceneManager.LoadScene("Game");
    }
}
