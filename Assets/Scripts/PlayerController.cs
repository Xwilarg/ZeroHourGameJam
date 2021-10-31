﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int _nextReceiver = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Receiver"))
        {
            var receiver = other.GetComponent<ObjectiveReceiver>();
            if (receiver.Order == _nextReceiver)
                _nextReceiver++;
        }
    }
}