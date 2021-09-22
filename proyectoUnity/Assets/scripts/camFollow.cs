using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour

{
    //Variable de tipo transform que está vinculada a la nave
    [SerializeField] Transform playerPosition;
    //Variables mov de la cámara
    [SerializeField] float distancia, altura = 1;
    Vector3 cameraPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);
        cameraPosition = new Vector3(0f, (playerPosition.position.y + altura), (playerPosition.position.z - distancia));
        transform.position = cameraPosition;
        // print(Input.GetAxis("Horizontal"));
        //No me funciona este código de debajo
        // transform.Translate(Vector3.left*Time.deltaTime*Input.GetAxis("Horizontal"));
    }
}
