using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public GameObject modal;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    private void OnMouseDown()
    {
        //modal.SetActive(true);
        Application.OpenURL("http://unity3d.com/");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
