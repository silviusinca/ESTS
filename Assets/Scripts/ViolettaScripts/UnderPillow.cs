using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnderPillow : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("UnderPillow");
    }
}
