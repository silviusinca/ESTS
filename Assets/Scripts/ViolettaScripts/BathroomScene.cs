using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BathroomScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("Bathroom");
    }
}
