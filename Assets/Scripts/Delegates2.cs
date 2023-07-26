using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Delegates1.testDelegateFunction += Delegates2Function;
    }

    void Delegates2Function()
    {
        Debug.Log("Blessed Mother, save us..");
    }

    private void OnEnable()
    {
        Delegates1.testDelegateFunction += Delegates2Function;

    }

    private void OnDisable()
    {
        Delegates1.testDelegateFunction -= Delegates2Function;
    }
}
