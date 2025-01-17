﻿using UnityEngine;

public class Wormhole : MonoBehaviour
{
    public Transform wormholeExit;
    public AudioSource sfx;

    private void OnTriggerEnter(Collider collision)
    {
        GameObject marble = collision.gameObject;
        Rigidbody marbleRB = marble.GetComponent<Rigidbody>();
        marbleRB.velocity = wormholeExit.transform.forward * marbleRB.velocity.magnitude;
        marble.transform.position = wormholeExit.transform.position;
        sfx.Play();
    }
}