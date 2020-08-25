using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public bool isGameEnded = false;
    [SerializeField]
    private float restartDelay = 3f;

    public void EndGame()
    {
        isGameEnded = true;
        Invoke("Restart", restartDelay);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
