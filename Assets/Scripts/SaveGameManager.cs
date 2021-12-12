using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    public static RawCard card;
    public static CardEffect effect;
    const string CARD_KEY = "/card";

    public void OnSave()
    {
        effect = (CardEffect)card.EffectList[card.EffectList.Count - 1];
        SaveSystem.SaveCard(card, effect);
        /*string key = CARD_KEY;
        SaveData data = new SaveData(card, effect);
        SaveSystem.Save(data, key);*/
    }


}