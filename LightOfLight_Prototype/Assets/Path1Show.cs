using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path1Show : MonoBehaviour
{
    private Renderer myRenderer; // ����B����Ⱦ��
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>(); // ��ȡ����B����Ⱦ��
        myRenderer.enabled = false; // ��ʼʱ����Ⱦ������
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {

        // ������ִ������B������ʱ���߼������粥�Ŷ���������������
        Debug.Log("����B�������ˣ�");
        myRenderer.enabled = true;
        if (myRenderer != null)
        {
            Debug.Log("SpriteRenderer ������ڣ�");
        }
        else
        {
            Debug.Log("SpriteRenderer ��������ڣ�");
        }
    }

    // ������B������ʱ����
    private void OnDisable()
    {
        // ������ִ������B������ʱ���߼�������ֹͣ�������ر�������
        Debug.Log("����B�������ˣ�");
    }
}
