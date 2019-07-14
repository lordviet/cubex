using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public GameObject pickupEffect;

    public float multiplier = 1.4f;

    public float duration = 4f; // the amount of seconds for the power up

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
           StartCoroutine( Pickup(other) ); //added StartCoroutine
        }
    }

    IEnumerator Pickup(Collider player) //replaced void with IEnumerator in order to wait x amount of time
    {
        Debug.Log("Power up picked up!");

        Instantiate(pickupEffect, transform.position, transform.rotation);

        player.transform.localScale *= multiplier; //multiply to change the size

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false; 

        yield return new WaitForSeconds(duration);

        player.transform.localScale /= multiplier; //divide to reverse the power up
        
            Destroy(gameObject);
    }
}
