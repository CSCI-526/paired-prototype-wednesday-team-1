using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path1Show : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*myRenderer = GetComponent<SpriteRenderer>();
        // ��ȡ����B����Ⱦ��
        if (myRenderer != null)
        {
            Debug.Log("SpriteRenderer ������ڣ�");
        }
        myRenderer.enabled = false; // ��ʼʱ����Ⱦ������*/
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {

        //Debug.Log("����B�������ˣ�");
        // ������ִ������B������ʱ���߼������粥�Ŷ���������������
        /*
        myRenderer.enabled = true;
        if (myRenderer != null)
        {
            Debug.Log("!!!������Onenable");
        }
        if(myRenderer.enabled == true)
        {
            Debug.Log("����B�������ˣ�");
        }
        else
        {
            Debug.Log("SpriteRenderer ��������ڣ�");
        }*/

    }

    // ������B������ʱ����
    private void OnDisable()
    {
        // ������ִ������B������ʱ���߼�������ֹͣ�������ر�������
        //Debug.Log("����B�������ˣ�");
    }
}
