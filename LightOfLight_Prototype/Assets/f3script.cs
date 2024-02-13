using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class f3script : MonoBehaviour
{
    public GameObject wall;

    private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.collider.CompareTag("Player"))
    {
        //Debug.Log("im here inside collison");
        if (collision.collider.CompareTag("Player")) 
        {
            wall.SetActive(true);
        }
    }
}

}
