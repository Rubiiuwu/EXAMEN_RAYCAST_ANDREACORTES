using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Text;
//using UnityEngineTMP;
public class Timer : MonoBehaviour
{
/*public Text textTimer;
public float timer = 5;
void Start();
{

}

void Update()
{
if(timer < 0)
    {
    SceneManager.LoadScene(1);
    }

timer -= Time.deltaTime;
textTimer.text = "" + timer.ToString("f1");
}

*/

void Start()
    {
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
