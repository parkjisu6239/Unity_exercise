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
        // ���콺 �ٷ� �� �ξƿ�
        currentZoom -= Input.GetAxis("Mouse ScrollWheel");
        // �� �ּ� �� �ִ� ���� 
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
    }

    void LateUpdate()
    {
        // ����� ī�޶� ��ġ ����
        transform.position = target.position + height + offset * currentZoom;
        transform.LookAt(target);
    }

}
