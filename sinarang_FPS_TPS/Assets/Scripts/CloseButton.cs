using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public GameObject modal;

    public void OnClickButton()
    {
        modal.SetActive(false);
        Debug.Log("Button Click!");
    }

}
