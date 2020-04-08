using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using player;
using Sirenix.OdinInspector;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [GUIColor(1f,0f,0f)]
    [SerializeField] private int _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyDamage(_damage);
        }
        
        Die();
    }

    [Button]
    private void Die()
    {
        gameObject.SetActive(false);
    }
}
