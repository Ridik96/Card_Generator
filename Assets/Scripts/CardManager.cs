using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardManager : MonoBehaviour
{
    public Button ExecuteButton;
    public Button CreateButton;
    public Button SaveButton;

    public RawCard card;
    public CreateCard Create;
    public EfektCardPerformer Performer;
    public SaveGameManager saveManager;
   [HideInInspector] public CardEffect currentEffect;

   
    void Start()
    {
        ExecuteButton.onClick.AddListener(delegate { Performer.OnEffectStart((CardEffect)Create.currentEffect); Create.OnCreateCard(card); ; });
        CreateButton.onClick.AddListener(delegate { Create.OnCreateCard(card); });
        SaveButton.onClick.AddListener(delegate { Create.Initialize(); /*SaveSystem.SaveCard(Create.currentCard, (CardEffect)Create.currentEffect);*/ saveManager.OnSave(); });
    }

    
}
