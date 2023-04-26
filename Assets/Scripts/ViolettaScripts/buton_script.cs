using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton_script : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Kitchen");
    }
}

