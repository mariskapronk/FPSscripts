﻿using UnityEngine;

public class AmmunitionPickup : MonoBehaviour, ILootable
{
    [SerializeField] private int ammunitionCount;
    [SerializeField] private AmmunitionTypes ammunitionType;

    public AudioSource AmmoPickup;

    public void OnStartLook()
    {
        Debug.Log($"Started looking at {ammunitionType}!"); 
    }

    public void OnInteract()
    {
           AmmunitionManager.instance.AddAmmunition(ammunitionCount, ammunitionType);
           AmmoPickup.Play();
           Destroy(gameObject);
    }

        public void OnEndLook()
    {
        Debug.Log($"Stopped looking at {ammunitionType}!");
    }
}
