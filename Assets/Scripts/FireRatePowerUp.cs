using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRatePowerUp : MonoBehaviour
{   [SerializeField]
    float multiplier=2f,duration=5f;
    //Destroy object on pickup
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
        StartCoroutine(DecreaseFireRate(other));
        }
    IEnumerator DecreaseFireRate(Collider2D player){
            ShootingController controller=other.GetComponent<ShootingController>();
            AudioSource source=GetComponent<AudioSource>();
            source.Play();
            controller.fireRate=controller.fireRate*multiplier;
            GetComponent<SpriteRenderer>().enabled=false;
            GetComponent<Collider2D>().enabled=false;
            yield return new WaitForSeconds(duration);
            controller.fireRate=controller.fireRate/multiplier;
            Destroy(gameObject);
        }
    } 
}