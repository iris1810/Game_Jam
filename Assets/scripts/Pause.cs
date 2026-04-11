using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseUI;

    private void Start()
    {
        PauseUI.SetActive(false);
        inputedActions.Instance.EnableInput();
    }

    public void GamePause()
    {
        PauseUI.SetActive(true);
        inputedActions.Instance.DisableInput();
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        inputedActions.Instance.EnableInput();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Title()
    {
        SceneManager.LoadScene("Title");
    }
}
