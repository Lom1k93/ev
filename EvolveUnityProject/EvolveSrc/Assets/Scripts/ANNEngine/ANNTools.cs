using UnityEngine;
using System.Collections;

public static class ANNTools
{
    public static float Sigmoid(float x)
    {
        return 1 / (1 + Mathf.Exp(-x));
    }
}
