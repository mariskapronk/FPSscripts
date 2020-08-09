using UnityEngine;

public class GunPickup : MonoBehaviour, ILootable
{
    [SerializeField] private Gun gun;
    public AudioSource GunPickUpSound;

    //public void OnStartLook()
    //{
    //    Debug.Log($"Started looking at {gun.gunName}!");
    //}

    public void OnInteract()
    {
        WeaponHandler.instance.PickUpGun(gun);
        Destroy(gameObject);
        GunPickUpSound.Play();
    }

    //public void OnEndLook()
    //{
    //    Debug.Log($"Stopped looking at {gun.gunName}!");
    //}

}
