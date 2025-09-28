using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Text boneTextValue;
    public Click click;

    private int bonesCount = 0;
    private int bonesValue = 1;

    public void UpdateBone()
    {
        bonesCount += bonesValue;
        UpdateBoneUI();
    }

    public int GetBonesCount()
    {
        return this.bonesCount;
    }

    public int SetBonesValue(int value)
    {
        return this.bonesValue = value;
    }

    public void UpdateBoneUI()
    {
        boneTextValue.text = bonesCount.ToString();
    }

    public void PaidBones(int valueAttribute)
    {
        bonesCount -= valueAttribute;
        UpdateBoneUI();
    }
}