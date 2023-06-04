using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject inventory;
    public static bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                ResumeGame();
            }
            else {
                PauseGame();
            }
        }
    }

    void PauseGame() {
        pauseMenu.SetActive(true);
        // leftButton.SetActive(false);
        // rightButton.SetActive(false);
        // inventory.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    
    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        // leftButton.SetActive(true);
        // rightButton.SetActive(true);
        // inventory.SetActive(true);

        Time.timeScale = 1f;
        isPaused = false;
    }

    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
