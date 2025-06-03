using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToScene1 : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("AR");
    }
}
