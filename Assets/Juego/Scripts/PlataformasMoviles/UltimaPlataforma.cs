using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimaPlataforma : MonoBehaviour
{
    [SerializeField]
    MovingPlatform platform;
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            platform.enabled = true;
            Destroy(gameObject);
        }
    }
}
