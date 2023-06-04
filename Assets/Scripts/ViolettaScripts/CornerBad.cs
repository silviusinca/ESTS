using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CornerBad : MonoBehaviour
{
    public void OnMouseDown()
    {
        SceneManager.LoadScene("NoteOfCodeStory");
    }
}
