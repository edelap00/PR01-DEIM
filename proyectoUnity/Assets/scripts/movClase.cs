using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movClase : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed1 = 5.0f;
    public float speed2 = 3.0f;
    public float speed3 = 1.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //----INTERACTIVIDAD//
        //lo multiplico por deltaTime, valor del eje y velocidad
       // transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);

        //Contador//

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("Contador");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine("Contador");
        }

        // movimientos nave
        //mov eje 1
        float DesplY = Input.GetAxis("Vertical") * speed1;
        transform.Translate(Vector3.up * DesplY * Time.deltaTime);

        //mov eje 2
        float DesplX = Input.GetAxis("Horizontal") * speed2;
        transform.Translate(Vector3.left * DesplX * Time.deltaTime);

        //mov eje 3
        float DesplZ = Input.GetAxis("Profundidad") * speed3;
        transform.Translate(Vector3.forward * DesplZ * Time.deltaTime);

    }

    IEnumerator Contador()
    {
        for(int n=0; ; n++) { 
        yield return new WaitForSeconds(1f);
            print("n es " + n);
        }
    }
}
