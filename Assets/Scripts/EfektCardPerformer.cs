using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfektCardPerformer : MonoBehaviour
{
    
    public List<Slider> statBars = new List<Slider>();

   [SerializeField] private List<string> statBarsTag = new List<string>();
    private float timeCounter;

    void Start()
    {
        for (int i = 0; i < statBars.Count; i++)
        {
            statBars[i].maxValue = 100f;
           
            statBarsTag[i] = statBars[i].tag;
        }
        
    }

    public void OnEffectStart(CardEffect effect)
    {
        for (int j = 0; j < effect.nameBar.Count; j++)
        {
            StartCoroutine(BarChange(effect.up, effect.nameBar[j], effect.actionResult, effect.actionTime));
        }
        
    }
    private IEnumerator BarChange(bool grows, string bartag, float actionResult,float time)
    {
        int curentBar = 0;
       
        foreach (string barTag in statBarsTag)
            if(bartag != barTag)
            {
                curentBar += 1;
                yield return null;
            }
            else if (bartag == barTag) 
            {
                break;
            }
          
           
        while (timeCounter < time)
        {
            timeCounter += Time.deltaTime;
            if(grows)
             {
                 statBars[curentBar].value += actionResult/time;
             }
            else
             {
                 statBars[curentBar].value -= actionResult/time;
             }

            yield return null;
        }
        timeCounter = 0F;
       
    }
    
}
