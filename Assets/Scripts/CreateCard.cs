using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CreateCard : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI title;
    [SerializeField] private TMPro.TextMeshProUGUI discripton;
    [SerializeField] private TMPro.TextMeshProUGUI effect;

   [SerializeField] private Image potion;

<<<<<<< Updated upstream:Assets/Scripts/ScriptableObjectsScripts/CreateCard.cs
    public RawCard cardData;
    public CardEffect posion;
    private void Start()
    {
        OnCreateCard();

    }
    private void OnCreateCard()
=======
    public ScriptableObject currentEffect;

  
    public void OnCreateCard(RawCard cardData)
>>>>>>> Stashed changes:Assets/Scripts/CreateCard.cs
    {
        int firstNumber;
        int secondNumber;
        int thirdNumber;
        int effectNumber;

        firstNumber = Random.Range(0, cardData.TitleList.Count);
        secondNumber = Random.Range(0, cardData.DiscriptionList.Count);
        thirdNumber = Random.Range(0, cardData.ImageList.Count);
        effectNumber = Random.Range(0, cardData.DiscriptionList.Count);


        title.text = cardData.TitleList[firstNumber];
        discripton.text = cardData.DiscriptionList[secondNumber];
        potion.sprite = cardData.ImageList[thirdNumber];
        currentEffect = cardData.EffectList[effectNumber];
        
    }

}
