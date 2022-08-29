using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerExample : MonoBehaviour
{
    public Text triggerText;

    public string triggerLog;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Dog"))
        {
            triggerText.text += "Dog has entered the trigger\n";
        }
        else if(other.CompareTag("Man"))
        {
            triggerText.text += "Man has entered the trigger\n";
        }            



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Dog"))
        {
            triggerText.text += "Dog has exited the trigger\n";
        }
        else if (other.CompareTag("Man"))
        {
            triggerText.text += "Man has exited the trigger\n";
        }
    }
}
