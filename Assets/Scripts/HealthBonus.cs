using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBonus : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            if (Player.GetComponent<HealthManager>().health != 100f)
            {
                Player.GetComponent<HealthManager>().Heal(50f);
                Destroy(gameObject);
            }
        }
        
    }
}
