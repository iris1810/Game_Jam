using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int level;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(level);
    }

}
