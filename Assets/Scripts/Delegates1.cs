using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates1 : MonoBehaviour
{
    public delegate void TestDelegate();
    public static TestDelegate testDelegateFunction;
    private void Start()
    {
        testDelegateFunction = MyFirstDelegateFunction;
        testDelegateFunction = MySecondDelegateFunction;
        testDelegateFunction = MyThirdDelegateFunction;
        
    }

    private void Update()
    {
        /* We need to sure null check because attempting to invoke a delegate 
         * without a method assigned to it will lead to a null reference error.*/
        
        if (Input.GetKeyDown(KeyCode.Space))  
        {
            testDelegateFunction?.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            testDelegateFunction = MyFirstDelegateFunction;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            testDelegateFunction = MySecondDelegateFunction;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            testDelegateFunction = MyThirdDelegateFunction;
        }
    }

    private void MyFirstDelegateFunction()
    {
        
        Debug.Log("Lilith was right1");
    }

    private void MySecondDelegateFunction()
    {
        Debug.Log("Lilith was right2");
    }

    private void MyThirdDelegateFunction()
    {
        Debug.Log("Lilith was right3");
    }

}
