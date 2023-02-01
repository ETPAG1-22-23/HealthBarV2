using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class degatboite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(20);

        }
        Debug.Log("cbc");
    }
}
