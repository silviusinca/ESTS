using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cadaBathroom : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (!PauseMenu.isPaused) {
            SceneManager.LoadScene("Cada");
        }
    }
}
