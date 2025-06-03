using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScene2 : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
