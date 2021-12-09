using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Posion Effect", menuName = "Create Posion Effect")]
public class PosionEffect : ScriptableObject
{
    public float posionTime;
    public float damage;
    public string effectDiscription;

}
