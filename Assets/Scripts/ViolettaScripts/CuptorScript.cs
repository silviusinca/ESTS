using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CuptorScript : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Cuptor");
    }
}

