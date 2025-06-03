using UnityEngine;

public class BGori : MonoBehaviour
{
    public int objectIndex;
    public GameObject objectToActivate;

    void Start()
    {
        if (DataBridge.Instance != null && DataBridge.Instance.objectToActivateIndex == objectIndex)
        {
            objectToActivate.SetActive(true);
        }
    }
}