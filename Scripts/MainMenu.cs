using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Main Menu");

            Time.timeScale = 1f;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
