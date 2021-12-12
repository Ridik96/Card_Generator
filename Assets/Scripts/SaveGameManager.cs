using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    public static RawCard card;
    public static CardEffect effect;
   

    public void OnSave()
    {
        effect = (CardEffect)card.EffectList[card.EffectList.Count - 1];
        SaveSystem.SaveCard(card, effect);
        
    }


}