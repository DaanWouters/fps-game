using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class interectable : MonoBehaviour
{


    public string promptMessage;


    public void BaseInteract()
    {
        interact();
    }


    protected virtual void interact()
    {
        // this is a template function to be overwritten by our subclasses
    }
}
