using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void setLoadScene(int _id)
    {
        SceneManager.LoadScene(_id);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
