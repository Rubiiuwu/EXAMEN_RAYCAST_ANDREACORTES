using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayoCamara : MonoBehaviour
{

    void Update()
    {    
        if(Input.GetButtonDown("Fire1"))
        {
        FixedUpdate();
        }
        }

    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast (ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.layer == 6)
            {
                Debug.Log(hit.transform.name);
                SceneManager.LoadScene(1);
            }

            if(hit.transform.gameObject.layer == 7)
            {
                Debug.Log(hit.transform.name);
                SceneManager.LoadScene(2);
            }
            if(hit.transform.gameObject.layer == 8)
            {
                Debug.Log(hit.transform.name);
                SceneManager.LoadScene(3);
            }
        }
    }

}


