using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
void Start()
    {
        //public Text text;
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("5");
        yield return new WaitForSeconds(5);
        Debug.Log("4");
        
        yield return new WaitForSeconds(4);
        Debug.Log("3");
        
        yield return new WaitForSeconds(3);
        Debug.Log("2");
        
        yield return new WaitForSeconds(2);
        Debug.Log("1");
        
    }

}
