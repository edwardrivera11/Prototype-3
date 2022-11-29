using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody playerRb;
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * 10000);
    }

    // Update is called once per frame
    void Update()
    {
         if ((Input.GetKeyDown(KeyCode.Space)))
         {
            playerRb.AddForce(Vector3.up * 100, ForceMode.Impulse);
         }
        
    }
}
