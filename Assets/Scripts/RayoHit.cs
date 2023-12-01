using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoHit : MonoBehaviour
{
 RaycastHit hit;

    void Start()
    {
        if(Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
        Debug.Log(hit.transform.name);
        Debug.Log(hit.transform.position);
        Debug.Log(hit.transform.gameObject.layer);
        Debug.Log(hit.transform.gameObject.tag);
        }
    }

    void Update()
    {
        
    }
}


/*Box caja = hit.transform.GetComponent <Box>();
            if(caja != null)
            {}*/

















/*RaycastHit hit;
if(Physics.Raycast(transform.position, transform.forward, out hit, 10))
{
Debug.Log(hit.transform.name);
Debug.Log(hit.transform.position);
Debug.Log(hit.transform.gameObject.layer);
Debug.Log(hit.transform.gameObject.tag);
if(hit.transform.gameObject.tag == "caja")
{
Box = script que tiene la caja
Box caja = hit.transform.GetComponent<Box>();
if(caja != null)
{
caja.TakeDamage(shootDamage)
}
}
else if(hit.transform.gameObject.tag == "Zapato")
{
Destroy(hit.transform.gameObject);
}
}
//Raycast de la camara
public Camara camaraPrincipal;
Ray ray = camaraPrincipal.ScreenPointToRay(Input.mousePosition)
RaycastHit hit;
if(Physics.Raycast(ray out hit. Mathf.infinity) && Input.GetButtonDown("Submit") /*Lo ultimo para activar el
rayo con un boton (enter) si no no se pone)*/
//{
    /*
Debug.DrawLine(Camera.main.transform.position, hit.position)
if(hit.transform.gameObject.layer == 7)
{
Debug.Log("impacto")
//Box = script que tiene la caja
Box box = hit.transform.gameObject.GetComponent<Box>();
if(box != null)
{
//TakeDamage = funcion del script "Box"
box.TakeDamage(2);
}
}
}
*/
