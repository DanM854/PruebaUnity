using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_animation : MonoBehaviour
{

    public Animator animator;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("hola");
            animator.SetTrigger("openChest");
            
        }
    }
}
