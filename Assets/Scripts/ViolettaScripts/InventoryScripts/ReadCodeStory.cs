using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadCodeStory : MonoBehaviour
{
    public void Use()
    {
        Debug.Log("Prefab clicked: ");
        SceneManager.LoadScene("ReadNote");
    }
}