using TMPro;
using UnityEngine;

public class AmmunitionUi : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ammunitionTypeText;
    [SerializeField] TextMeshProUGUI ammunitionCountText;

    private CanvasGroup canvasGroup;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void UpdatedAmmunitionType (Gun gun)
    {
        if(gun == null)
        {
            canvasGroup.alpha = 0;
            return;
        }

        canvasGroup.alpha = 1;

        UpdateAmmunitionCount(AmmunitionManager.instance.GetAmmunitionCount(gun.ammunitionType));

        ammunitionTypeText.text = gun.ammunitionType.ToString();
    }

    public void UpdateAmmunitionCount(int newCount)
    {
        ammunitionCountText.text = newCount.ToString();
    }
}
