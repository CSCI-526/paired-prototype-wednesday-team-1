using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path1Show : MonoBehaviour
{
    private Renderer myRenderer; // 物体B的渲染器
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>(); // 获取物体B的渲染器
        myRenderer.enabled = false; // 初始时将渲染器禁用
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {

        // 在这里执行物体B被激活时的逻辑，例如播放动画、发出声音等
        Debug.Log("物体B被激活了！");
        myRenderer.enabled = true;
        if (myRenderer != null)
        {
            Debug.Log("SpriteRenderer 组件存在！");
        }
        else
        {
            Debug.Log("SpriteRenderer 组件不存在！");
        }
    }

    // 当物体B被禁用时调用
    private void OnDisable()
    {
        // 在这里执行物体B被禁用时的逻辑，例如停止动画、关闭声音等
        Debug.Log("物体B被禁用了！");
    }
}
