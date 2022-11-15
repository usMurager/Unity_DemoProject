using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int count;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<PlayerControls>().AddCoin(count);
            Destroy(gameObject);
        }
    }
}
