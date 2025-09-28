using UnityEngine;
using UnityEngine.UI;

public class MultipleBones : MonoBehaviour
{
    public Click click;
    public Text priceAttributeText;

    private int priceAttribute = 20;
    private int bonesValue = 1;

    public void UpdatePriceUI()
    {
        priceAttributeText.text = priceAttribute.ToString();
    }

    public int GetPriceAttribute()
    {
        return this.priceAttribute;
    }

    public void BuyMultipleBones()
    {
        if(click.GetBonesCount() >= priceAttribute)
        {
            IncreaseBones();
            priceAttribute += priceAttribute;
            UpdatePriceUI();
            
        }else
        {
            Debug.Log("Do you need more bones!");
        }
    }

    public void IncreaseBones()
    {
        bonesValue += 1;
        click.PaidBones(priceAttribute);
        click.SetBonesValue(bonesValue);
    }

}