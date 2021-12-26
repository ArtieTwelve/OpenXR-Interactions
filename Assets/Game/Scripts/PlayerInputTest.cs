using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputTest : MonoBehaviour
{

    public void Red(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed) {
         Debug.Log("Red Button pushed: phase: " + context.phase);
         GetComponent<Renderer>().material.color = Color.red;
        }
    }
    public void Blue(InputAction.CallbackContext context)
    {
          if(context.phase == InputActionPhase.Performed) {
        Debug.Log("Blue Button pushed: phase: " + context.phase);
         GetComponent<Renderer>().material.color = Color.blue;
          }
    }

     public void Green(InputAction.CallbackContext context)
    {
          if(context.phase == InputActionPhase.Performed) {
        Debug.Log("Green Button pushed: phase: " + context.phase);
         GetComponent<Renderer>().material.color = Color.green;
          }
    }
    public void Yellow(InputAction.CallbackContext context)
    {
          if(context.phase == InputActionPhase.Performed) {
        Debug.Log("Yellow Button pushed: phase: " + context.phase);
         GetComponent<Renderer>().material.color = Color.yellow;
          }
    }

     public void Cyan(InputAction.CallbackContext context)
    {
          if(context.phase == InputActionPhase.Performed) {
        Debug.Log("Cyan Button pushed: phase: " + context.phase);
         GetComponent<Renderer>().material.color = Color.cyan;
          }
    }
    public void Grey(InputAction.CallbackContext context)
    {
          if(context.phase == InputActionPhase.Performed) {
        Debug.Log("Grey Button pushed: phase: " + context.phase);
         GetComponent<Renderer>().material.color = Color.grey;
          }
    }
   
}
