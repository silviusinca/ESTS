using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class masaScript : MonoBehaviour
{
    public void OnMouseDown(){
        if (!PauseMenu.isPaused) {
            SceneManager.LoadScene("masaBuc");
        }
    }
}
