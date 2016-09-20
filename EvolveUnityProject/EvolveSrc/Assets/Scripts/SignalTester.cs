using UnityEngine;
using System.Collections;

public class SignalTester : MonoBehaviour
{
    private void Update()
    {
        if ((int)Time.time % 3 == 0)
        {
            float randomSignalPower = Random.Range(-0.57f, 3.66f);
            Debug.LogFormat("input signal {0}, sigmoid modification {1}", randomSignalPower, ANNTools.Sigmoid(randomSignalPower));
        }
    }
}
