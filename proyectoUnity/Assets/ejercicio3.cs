using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{

    [SerializeField] string nombreIns = "Elisa";
    [SerializeField] float num1, num2, opcion;
        float numres;
    // Start is called before the first frame update
    void Start()
    {
        //Ejercicio 3 a
       // Saludo(nombreIns);

        //Ejercicio 3b
       // Opera(num1, num2);
       

        //Ejercicio 3c
        //  StartCoroutine("Segundos");

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    float Opera(float num1, float num2)
    {
       
        print("Seleccione la opci�n: 1 para sumar, 2 para restar, 3 para multiplicar, 4 para dividir");
        switch (opcion)
        {
            case 1:
                numres = num1 + num2;
                print("La suma de ambos n�meros es "+numres);
                break;
            case 2:
                numres = num1 - num2;
                print("La resta es " + numres);
                break;
            case 3:
                numres = num1 * num2;
                print("La multiplicaci�n es "+numres);
                break;
            case 4:
                numres = num1 / num2;
                print("La divisi�n es "+ numres);
                break;
            default:
                print("No est�s seleccionando una opci�n de operaci�n correcta");
                break;
        }
        return numres;
    }
    IEnumerator Segundos()
    {
        int sec = 0;
        int min = 00;
        int hor = 00;

        for (; ;sec++)
        {
 
            yield return new WaitForSeconds(1f);
           if (sec >= 60)
            {
                min++;
                sec = 0;
            }
           if (min >= 60)
            {
                hor++;
                min = 00;
            }
            print(hor.ToString("D2")+":"+ min.ToString("D2") + ":"+ sec.ToString("D2"));
        }
    }

    void Saludo(string nombreIns)
    { 
            print("Hola " + nombreIns);
     }

}
