using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        OpenAuthor();
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Edia Zaki Naufal Ilman");
    }
}