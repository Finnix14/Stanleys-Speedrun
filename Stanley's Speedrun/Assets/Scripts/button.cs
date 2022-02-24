using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{

    [SerializeField] public GameObject door;

    public bool doorIsOpening;

    void Update()
    {
        if(doorIsOpening == true)
        {
            door.transform.Translate(Vector3.up * Time.deltaTime * 5);

        }
        if(door.transform.position.y > 7f)
        {
            doorIsOpening = false;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        doorIsOpening = true;
    }

}
