using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class SaveSystem 
{
    public static string path = Application.persistentDataPath + "/data.sav";
    public static SaveData data;
    public static Dictionary<string, string> saveCard = new Dictionary<string, string>();

    public static void SaveCard(RawCard card, CardEffect effect)
    {
        CardData cardData = new CardData(card, effect);
        string cardJson = JsonUtility.ToJson(cardData);
       if(!saveCard.ContainsKey(card.name))
        {
            saveCard.Add(card.name, cardJson);
            Debug.Log("New Save Card");
        }
        else
        {
            saveCard[card.name] = cardJson;
            Debug.Log("Save card");
        }
    }

   public static void SaveData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);
        data = new SaveData(saveCard);
        formatter.Serialize(stream, data);
        stream.Close();
    }
}
 
public class SaveData
{
    public string[] cardName;
    public string[] cardJson;

    public SaveData(Dictionary<string,string> card)
    {
        cardName = new string[card.Count];
        cardJson = new string[card.Count];

        var cardKeys = card.Keys.ToArray();
        var cardValues = card.Values.ToArray();

        for(int i = 0; i < card.Count; i++)
        {
            cardName[i] = cardKeys[i];
            cardJson[i]=cardValues[i];
        }
    }
}