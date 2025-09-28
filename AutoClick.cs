using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{
    public Click click;
    public Text priceAttributeText;

    private float currentTime = 0.0f;
    private float declaredTime = 60.0f;

    private int priceAttribute = 10;

    private bool isTimerRunning = false;
    private bool isBuyedBefore = false;

    public void UpdatePriceUI()
    {
        priceAttributeText.text = priceAttribute.ToString();
    }

    public int GetPriceAttribute()
    {
        return this.priceAttribute;
    }


    public void StartTimer()
    {
        currentTime = 0f;
        isTimerRunning = true;
        isBuyedBefore = true;
    }


    private void Update()
    {
        if(isTimerRunning)
        {
            currentTime += Time.deltaTime;
            
            if(currentTime >= declaredTime)
            {
                click.UpdateBone();
                isTimerRunning = false;
                StartTimer();
            }
        }
    }


    public void BuyAutoClicker()
    {
        if(click.GetBonesCount() >= priceAttribute)
        {
            click.PaidBones(priceAttribute);
            priceAttribute += priceAttribute;
            UpdatePriceUI();

            if(!isBuyedBefore)
            {
                StartTimer();
            }
            
            if(declaredTime > 1.0f)
            {
                declaredTime -= 1.0f;
            }
        }
        else
        {
            Debug.Log("Do you need more bones!");
        }
    }
}