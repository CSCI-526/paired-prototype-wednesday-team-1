using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Path1;
   
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")) // ����ײ�����������ʱ
        {
            Path1.SetActive(true); // ��������B
            if (Path1.activeSelf) // �������B�Ƿ��Ѿ��Ǽ���״̬
            {
                Debug.Log("����B�Ѿ��Ǽ���״̬��");
            }

        }
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
