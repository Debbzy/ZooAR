using UnityEngine;

public class DataBridge : MonoBehaviour
{
    public static DataBridge Instance;

    public int objectToActivateIndex = -1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}