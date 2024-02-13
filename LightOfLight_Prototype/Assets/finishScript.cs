using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishScript : MonoBehaviour
{
    public GameObject flagBefore;
    public GameObject flagAfter;

    private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.collider.CompareTag("Player"))
    {
        
        if (collision.collider.CompareTag("Player")) 
        {

            flagAfter.SetActive(true);
            flagBefore.SetActive(false);
        }
    }
}
}
