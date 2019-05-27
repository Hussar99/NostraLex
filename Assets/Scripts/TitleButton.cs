using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This allows to use the scene loading function.
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour {

    // Called when the button  is clicked.
    public void GoToTitle()
    {

        //  Return to title screen.
        SceneManager.LoadScene("MainMenu");

    }

}
