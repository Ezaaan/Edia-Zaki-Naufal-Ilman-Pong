using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        OpenAuthor();
    }

    public void PlayCredit()
    {
        SceneManager.LoadScene("Credit Scene");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Edia Zaki Naufal Ilman");
    }
}