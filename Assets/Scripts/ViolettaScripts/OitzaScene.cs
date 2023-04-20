using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OitzaScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Oitza");
    }
}

