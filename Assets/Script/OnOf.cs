using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOf : MonoBehaviour
{
    public GameObject targetObject;
    private bool isOn = false;

    public void ToggleObject()
    {
        isOn = !isOn;
        if (targetObject != null)
        {
            targetObject.SetActive(isOn);
        }
    }
}
