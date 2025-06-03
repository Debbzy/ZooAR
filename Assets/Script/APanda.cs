using UnityEngine;
using UnityEngine.SceneManagement;

public class APanda : MonoBehaviour
{
    public GameObject[] watchedObjects;
    private bool hasLoaded = false;

    void Update()
    {
        if (hasLoaded) return;

        for (int i = 0; i < watchedObjects.Length; i++)
        {
            if (watchedObjects[i].activeInHierarchy)
            {
                if (DataPanda.Instance == null)
                {
                    GameObject go = new GameObject("DataBridge");
                    go.AddComponent<DataPanda>();
                }

                DataPanda.Instance.objectToActivateIndex = i;
                hasLoaded = true;
                break; // hanya satu objek per kali
            }
        }
    }
}