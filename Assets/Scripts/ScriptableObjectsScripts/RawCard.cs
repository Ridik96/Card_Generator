using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Now Card",menuName = "Create Card")]
public class RawCard : ScriptableObject
{
    public List<string> TitleList = new List<string>();
    public List<string> DiscriptionList = new List<string>();

    public List<Sprite> ImageList = new List<Sprite>();

}
