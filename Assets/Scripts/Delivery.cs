using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] AudioClip deliverySFX;
    [SerializeField] AudioClip pickupSFX;
    [SerializeField] Color32 hasPackageColor = new Color32(225, 57, 22, 225);
    [SerializeField] Color32 noPackageColor = new Color32(225, 57, 22, 225);
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;
    AudioSource audioSource;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    
    //void OnCollisionEnter2D(Collision2D other)
    //{
     //   Debug.Log("Hello world");
   // }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up");
            audioSource.clip = pickupSFX;
            audioSource.Play();
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            audioSource.clip = deliverySFX;
            audioSource.Play();
            hasPackage = false;
          
          int count= GameObject.FindGameObjectsWithTag("Package").Length;
           
            if (count == 0)
            {
              Debug.Log("Game Over");

              FindObjectOfType<GameManager>().GameOver();
            }
            spriteRenderer.color = noPackageColor;
        }

    }
}
