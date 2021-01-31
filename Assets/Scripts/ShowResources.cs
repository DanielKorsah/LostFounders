using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowResources : MonoBehaviour
{
    public long Total;
    public double CPM;

    private TextMeshProUGUI output;
    void Start ()
    {
        output = GetComponentInChildren<TextMeshProUGUI> ();
    }

    // Update is called once per frame
    void Update ()
    {
        Total = GameManager.Resources;
        output.text = "Resources:\n" + Total + "\n" + CPM  + "CPM";
    }
}