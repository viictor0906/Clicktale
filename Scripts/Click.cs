using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    int boneValue = 0;
    public Text boneTextValue;

    public void UpdateBone()
    {
        boneValue ++;
        UpdateBoneUI();
    }

    public int getBoneValue()
    {
        return boneValue;
    }

    public void UpdateBoneUI()
    {
        boneTextValue.text = boneValue.ToString();
    }
}
