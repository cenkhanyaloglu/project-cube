using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    #region MainMenu
    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LoadLevel02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void LoadLevel03()
    {
        SceneManager.LoadScene("Level03");
    }

    public void LoadLevel04()
    {
        SceneManager.LoadScene("Level04");
    }

    public void LoadLevel05()
    {
        SceneManager.LoadScene("Level05");
    }

    public void LoadLevel06()
    {
        SceneManager.LoadScene("Level06");
    }
    #endregion

    #region LevelComplete
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    #endregion
}
