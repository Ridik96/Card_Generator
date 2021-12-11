using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Card Effect", menuName = "Create new Effect")]
public class CardEffect : ScriptableObject
{
    public float actionTime;
    public float actionResult;
    public string effectDiscription;
    public List<string> nameBar;
    public bool up;

    
}
