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
        Debug.Log("5" + Time.time);

        yield return new WaitForSeconds(5);

        Debug.Log("5" + Time.time);
    }

}
