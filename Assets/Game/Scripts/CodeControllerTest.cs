using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
     This script creates InputActions in the Awake method and sets up the performed callbacks

*/
public class CodeControllerTest : MonoBehaviour
{
     [SerializeField] private GameObject actionObject;
    private InputAction leftPrimary, rightPrimary;

    
     void Awake()
       // Below is what you get when you copy Input Actions directly from the action map. Good for getting the correct controller string
    {   // INPUTASSET BindingTreeItem{"m_Name":"","m_Id":"a1d431af-aba3-4f4c-a243-924d9987239f","m_Path":"<XRController>{LeftHand}/primaryButton","m_Interactions":"","m_Processors":"","m_Groups":"","m_Action":"Primary","m_Flags":0}
       
       
        // Setup two input actions from the controller strings
        leftPrimary = new InputAction(name:"PrimaryButtons",binding: "<XRController>{LeftHand}/primaryButton");
        leftPrimary.Enable();
        leftPrimary.performed += ColorChange;//  {Debug.Log("Button Click: name: " + context.phase);};

        rightPrimary = new InputAction(name:"PrimaryButtons",binding: "<XRController>{RightHand}/primaryButton");
        rightPrimary.Enable();
        rightPrimary.performed += ColorChange;
    }
    
    private void OnDisable() {
         leftPrimary.performed -= ColorChange;
         rightPrimary.performed -= ColorChange;
    }

    private void ColorChange(InputAction.CallbackContext context) {
         // change to a random color
         Color color = new Color(Random.value,Random.value,Random.value,Random.value);
         actionObject.GetComponent<Renderer>().material.color = color;
    }

//    Alter this method to do a transform change
//     private void ColorChangeBack(InputAction.CallbackContext context) {
//          // c
//          Color color = new Color(Random.value,Random.value,Random.value);
//          actionObject.GetComponent<Renderer>().material.color = color;
//     }

   
}
