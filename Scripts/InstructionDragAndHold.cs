using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionDragAndHold : MonoBehaviour
{
    public GameObject instruction;
    // Start is called before the first frame update
    void Start()
    {
        instruction.SetActive(false);
    }


    void OnMouseOver()
    {
         instruction.SetActive(true);
    }

    void OnMouseExit()
    {
        instruction.SetActive(false);
    }

}
