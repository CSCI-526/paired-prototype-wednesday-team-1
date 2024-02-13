using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Path1;
   
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player")) // 当碰撞的物体是玩家时
        {
            Path1.SetActive(true); // 激活物体B
            if (Path1.activeSelf) // 检查物体B是否已经是激活状态
            {
                Debug.Log("物体B已经是激活状态！");
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
