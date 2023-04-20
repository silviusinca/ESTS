using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeifScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Seif");
    }
}
