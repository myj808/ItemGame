
using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator CollectAndDestroy()
    {
        PlaySound();
        yield return new WaitForSeconds(audioSource.clip.length);
        Destroy(gameObject);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlaySound();
            GameManager.Instance.CollectItem();
            StartCoroutine(CollectAndDestroy());  
        }
    }

    private void PlaySound()
    {
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play(); // À½¾Ç Àç»ý
        }
    }
}




