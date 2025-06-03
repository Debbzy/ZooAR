using UnityEngine;

public class MSinga : MonoBehaviour
{
    public int objectIndex;
    public GameObject objectToActivate;

    void Start()
    {
        if (DataSinga.Instance != null && DataSinga.Instance.objectToActivateIndex == objectIndex)
        {
            objectToActivate.SetActive(true);
        }
    }
}