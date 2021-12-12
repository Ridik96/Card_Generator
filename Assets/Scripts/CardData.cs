using UnityEngine;

[System.Serializable]
public class CardData
{
    public  string titleText;
    public string discriptionText;
    public string effectText;

    public  Sprite image;

    public float actionTime;
    public float actionResult;
    public string effectDiscription;
    public string[] nameBar;
    public bool up;

    public CardData(RawCard card, CardEffect effect)
    {
        titleText = card.TitleList[card.TitleList.Count-1];
        discriptionText = card.DiscriptionList[card.DiscriptionList.Count - 1];
        effectText = effect.name;
        image = card.ImageList[card.ImageList.Count - 1];
        actionTime = effect.actionTime;
        actionResult = effect.actionResult;
        effectDiscription = effect.effectDiscription;
        up = effect.up;
        nameBar = new string[effect.nameBar.Count];
        for (int i=0;i<effect.nameBar.Count;i++)
        {
            nameBar = new string[]
            {
                effect.nameBar[i]
            };
        }

    }
       
    
}
