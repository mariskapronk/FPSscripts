using UnityEngine;

public abstract class Gun : MonoBehaviour //can't be added to an object, but declares what each gun must have
{
    public string gunName;
    public GameObject gunPickup;

    [Header("Stats")]
    public AmmunitionTypes ammunitionType;
    public int minimumDamage;
    public int maximumDamage;
    public float maximumRange;
    public float fireRate;

    protected float timeOfLastShot;

    private Transform cameraTransform;

    public AudioSource PistolGunSound;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        PistolGunSound = GetComponent<AudioSource>();
    }

    //private but public for other scripts from gun

    protected void Fire()
    {
        if(AmmunitionManager.instance.ConsumeAmmunition(ammunitionType))
        {
            RaycastHit whatIHit;
            PistolGunSound.Play();
            if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out whatIHit, Mathf.Infinity))
            {
                IDamageable damageable = whatIHit.collider.GetComponent<IDamageable>();
                if (damageable != null)
                {
                    float normalisedDistance = whatIHit.distance / maximumRange;
                    if (normalisedDistance <= 1)
                    {
                        damageable.DealDamage(Mathf.RoundToInt(Mathf.Lerp(maximumDamage, minimumDamage, normalisedDistance)));
                    }
                }
            }
        }

    }
}