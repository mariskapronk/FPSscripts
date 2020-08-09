using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public static WeaponHandler instance;

    private Gun currentGun;
    private GameObject currentGunPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    //drop and grab gun
    public void PickUpGun (Gun gun) 
    {
        if(currentGun != null)
        {
            Instantiate(currentGun.gunPickup, transform.position + transform.forward, Quaternion.identity);
            Destroy(currentGunPrefab);
        }

        currentGun = gun;
        currentGunPrefab = Instantiate(gun.gameObject, transform);

        AmmunitionManager.instance.ammunitionUi.UpdatedAmmunitionType(currentGun);
    }
}
