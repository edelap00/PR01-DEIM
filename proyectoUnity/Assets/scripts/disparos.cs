using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Disparo();
        }

        StartCoroutine("DisparoAuto");
    }

    void Disparo()
    {
       
            print("pium PIUM!!");
       
    }

    IEnumerator DisparoAuto()
    {
        for (int n = 0; ; n++)
        {
            yield return new WaitForSeconds(4f);

            //En vez de esto, podría llamar desde aquí simplemente al método disparo
            print("Soy un disparo automático PIUM PIUM!! "+n);
        }
    }
}
