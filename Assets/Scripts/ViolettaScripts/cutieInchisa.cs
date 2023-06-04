using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutieInchisa : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (addToInventory.objectsAdded.Contains("cutit") && !PauseMenu.isPaused){
            SceneManager.LoadScene("cutie");
        }
    }
}
