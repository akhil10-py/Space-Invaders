using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePowerup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            StartCoroutine (AddLives(other));
        } 
     IEnumerator AddLives(Collider2D player){
        Health lives=other.GetComponent<Health>();
        if(lives.currentLives<3){
        AudioSource source=GetComponent<AudioSource>();
        source.Play();
        GetComponent<SpriteRenderer>().enabled=false;
        GetComponent<Collider2D>().enabled=false;
        lives.hearts[lives.currentLives].gameObject.SetActive(true);
        lives.currentLives+=1;
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);}
        
        
    }  
}

}
