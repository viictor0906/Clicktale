using UnityEngine;

public class AutoClick : MonoBehaviour
{
    public Click click;

    private float currentTime = 0f;
    private float declaredTime = 2f;
    private bool isTimerRunning = false;

    private int priceAtribute = 10;

    public void StartTimer()
    {
        currentTime = 0f;
        isTimerRunning = true;
    }

    private void Update()
    {
        if(isTimerRunning == true)
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
        if(click.getBoneValue() >= priceAtribute)
        {
            StartTimer();
        }else
        {
            Debug.Log("Do you need more bones!");
        }
    }
}