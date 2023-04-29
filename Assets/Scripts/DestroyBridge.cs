using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBridge : MonoBehaviour
{
    [SerializeField] private Bridge _bridge;
    [SerializeField] private PickUpItem _pick;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            _bridge.Break();
        }
    }

    private void Update()
    {
        if (_pick.IsPotionTaken)
        {
            gameObject.SetActive(false);
        }
    }
}
