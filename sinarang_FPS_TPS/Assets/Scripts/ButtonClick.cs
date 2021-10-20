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
        modal.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
