using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyMainOpenDoor : MonoBehaviour
{

    public GameObject Instruction;
    public GameObject AnimeObjectLeftDoor, AnimeObjectRightDoor;
    //public GameObject ThisTrigger;
    //public AudioSource DoorOpenSound;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                AnimeObjectLeftDoor.GetComponent<Animator>().Play("MainDoorOpen1");
                AnimeObjectRightDoor.GetComponent<Animator>().Play("MainDoorOpen2");
                //ThisTrigger.SetActive(false);
                //DoorOpenSound.Play();
                Action = false;
            }
        }

    }
}
