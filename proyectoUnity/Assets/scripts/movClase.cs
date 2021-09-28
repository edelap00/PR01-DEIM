using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movClase : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //----INTERACTIVIDAD//
        //lo multiplico por deltaTime, valor del eje y velocidad
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("Contador");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine("Contador");
        }

    }

    IEnumerator Contador()
    {
        for(int n=0; ; n++) { 
        yield return new WaitForSeconds(1f);
            print("n es " + n);
        }
    }
}
