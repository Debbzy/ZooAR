using UnityEngine;

public class DataSinga : MonoBehaviour
{
    public static DataSinga Instance;

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