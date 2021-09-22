using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{

    [SerializeField] Vector3 playerPosition = new Vector3(1f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
