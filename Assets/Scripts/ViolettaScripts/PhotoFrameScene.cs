using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotoFrameScene : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("PhotoFrame");
    }
}
