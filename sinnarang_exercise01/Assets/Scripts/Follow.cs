using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    private float currentZoom = 1.0f;

    public float minZoom = 0.5f;
    public float maxZoom = 1.5f;

    public Transform target;
    public Vector3 offset;
    public Vector3 height;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
        // 마우스 휠로 줌 인아웃
        currentZoom -= Input.GetAxis("Mouse ScrollWheel");
        // 줌 최소 및 최대 설정 
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    }

    void LateUpdate()
    {
        // 변경된 카메라 위치 적용
        transform.position = target.position + height + offset * currentZoom;
        transform.LookAt(target);
    }

}
