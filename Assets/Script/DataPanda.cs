using UnityEngine;

public class DataPanda : MonoBehaviour
{
    public static DataPanda Instance;

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