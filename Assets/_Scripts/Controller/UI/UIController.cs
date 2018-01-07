using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour {
    public GameObject optionsTint;                          //Store a reference to the Game Object OptionsTint 
    public GameObject pausePanel;                           //Store a reference to the Game Object PausePanel 
    public GameObject gameOverPanel;
    public GameObject debugPanel;
    public GameObject messagePanel;

    //Call this function to activate and display the Pause panel during game play
    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
        optionsTint.SetActive(true);
    }

    //Call this function to deactivate and hide the Pause panel during game play
    public void HidePausePanel()
    {
        pausePanel.SetActive(false);
        optionsTint.SetActive(false);

    }
    ////Call this function to activate and display the GameOver panel during game play
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
        optionsTint.SetActive(true);
    }

    //Call this function to deactivate and hide the GameOver panel during game play
    public void HideGameOverPanel()
    {
        gameOverPanel.SetActive(false);
        optionsTint.SetActive(false);

    }
    ////Call this function to activate and display the Debug panel during game play
    public void ShowDebugPanel()
    {
        debugPanel.SetActive(true);
    }

    //Call this function to deactivate and hide the Debug panel during game play
    public void HideDebugPanel()
    {
        debugPanel.SetActive(false);
    }

    ////Call this function to activate and display the Debug panel during game play
    public void ShowMessagePanel()
    {
        messagePanel.SetActive(true);
    }

    //Call this function to deactivate and hide the Debug panel during game play
    public void HideMessagePanel()
    {
        messagePanel.SetActive(false);
    }
}
