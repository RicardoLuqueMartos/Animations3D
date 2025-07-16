using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject GameMenuObject;


    private void Start()
    {
        HideMenu();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void DisplayMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        GameMenuObject.SetActive(true);
    }

    public void HideMenu()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GameMenuObject.SetActive(false);
    }

}
