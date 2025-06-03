using UnityEngine;

public class MPanda : MonoBehaviour
{
    public int objectIndex;
    public GameObject objectToActivate;

    void Start()
    {
        if (DataPanda.Instance != null && DataPanda.Instance.objectToActivateIndex == objectIndex)
        {
            objectToActivate.SetActive(true);
        }
    }
}