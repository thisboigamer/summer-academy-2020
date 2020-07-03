using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider colliderInfo)
    {
        //limit to only when Player enters the field
        if (colliderInfo.tag == "Player")
        //Collider target = Collider.GetComponent(colliderInfo.tag);
        {
            FindObjectOfType<GameManager>().WinGame();
        }
    }
  
}
