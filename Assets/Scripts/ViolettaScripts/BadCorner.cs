using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadCorner : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (!PauseMenu.isPaused) {
            SceneManager.LoadScene("NoteOfCodeStory");
        }
    }
    
}
