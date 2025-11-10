using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collection)
    {
        if(collection.CompareTag("Player"))
        {
            manager.AddScore(1);
            Destroy(this.gameObject);
        } 
    }
}
