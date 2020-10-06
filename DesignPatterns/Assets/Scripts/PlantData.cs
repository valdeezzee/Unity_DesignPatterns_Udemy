using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "plantdata", menuName = "Plant Data", order = 51)]
public class PlantData : ScriptableObject
{
    public enum THREAT { None, Low, Moderate, High}
    
    [SerializeField]
    private string plantName;
    [SerializeField]
    private THREAT plantThreat;
    [SerializeField]
    private Texture icon;

    public string PlantName { get => plantName; set => plantName = value; }
    public THREAT PlantThreat { get => plantThreat; set => plantThreat = value; }
    public Texture Icon { get => icon; set => icon = value; }
}
