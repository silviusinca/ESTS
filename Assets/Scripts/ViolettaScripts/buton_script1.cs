using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton_script1 : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Kitchen");
    }
}

