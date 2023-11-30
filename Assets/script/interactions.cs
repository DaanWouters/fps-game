using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public  abstract class interactions : MonoBehaviour
{
    public bool useEvents;
    [SerializeField]
    public string promptMessage; //message displayed to player when looking at an interactable



    public virtual string OnLook()
    {
        return promptMessage;
    }

    public void BaseInteract()
    {
        if (useEvents)
        interact();
    }
    protected virtual void interact()
    {

    }
   
}
