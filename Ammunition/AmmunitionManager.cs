using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AmmunitionManager : MonoBehaviour
{
    public static AmmunitionManager instance;

    public AmmunitionUi ammunitionUi;

    //geeft een waarde aan de ammotypes
    private Dictionary<AmmunitionTypes, int> ammunitionCounts = new Dictionary<AmmunitionTypes, int>();

    //stops us from getting duplicates
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        for (int i = 0; i < Enum.GetNames(typeof(AmmunitionTypes)).Length; i++)
        {
            ammunitionCounts.Add((AmmunitionTypes)i, 0);
        }
    }

    public void AddAmmunition(int value, AmmunitionTypes ammunitionType)
    {
        ammunitionCounts[ammunitionType] += value;
        ammunitionUi.UpdateAmmunitionCount(ammunitionCounts[ammunitionType]);
    }

    public int GetAmmunitionCount(AmmunitionTypes ammunitionType)
    {
        return ammunitionCounts[ammunitionType];
    }

    public bool ConsumeAmmunition(AmmunitionTypes ammunitionType)
    {
        if(ammunitionCounts[ammunitionType] > 0)
        {
            ammunitionCounts[ammunitionType]--;
            ammunitionUi.UpdateAmmunitionCount(ammunitionCounts[ammunitionType]);
            return true;
        }
        else
        {
            return false;
        }
    }
}
