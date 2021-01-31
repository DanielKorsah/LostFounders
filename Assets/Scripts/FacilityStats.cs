using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacilityStats : MonoBehaviour
{
    public string facilityName;
    public int facilityBasePrice = 1;
    public int facilityCurrentPrice = 1;
    public int facilityPreviousPrice = 0;
    public int facilityUpgradeCost = 0;
    public int facilityUnlockCost = 0;

    [SerializeField] private TooltipTrigger[] tooltips;

    void Start()
    {
        tooltips = GetComponentsInChildren<TooltipTrigger>();
        facilityCurrentPrice = facilityBasePrice;
    }

    private void Update()
    {
        tooltips[0].Content = String.Format("Buy a {0} for {1} resources.", facilityName, facilityCurrentPrice);
        tooltips[1].Content = String.Format("Sell a {0} for {1} resources.", facilityName, facilityPreviousPrice);
        tooltips[2].Content = String.Format("Upgrade {0} for {1} resources.", facilityName, facilityUpgradeCost);
        tooltips[3].Content = String.Format("Unlock {0} for {1} resources.", facilityName, facilityUnlockCost);
    }
}
