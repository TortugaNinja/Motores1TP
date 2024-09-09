using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSizeAndColour : MonoBehaviour
{

    public void SetPaddleHeight(float xNewScale)
    {
        float xSize;
        xSize = transform.localScale.x + xNewScale;

    }
}
