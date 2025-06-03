using UnityEngine;
using UnityEngine.SceneManagement;

public class AGori : MonoBehaviour
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
                if (DataBridge.Instance == null)
                {
                    GameObject go = new GameObject("DataBridge");
                    go.AddComponent<DataBridge>();
                }

                DataBridge.Instance.objectToActivateIndex = i;
                hasLoaded = true;
                break; // hanya satu objek per kali
            }
        }
    }
}