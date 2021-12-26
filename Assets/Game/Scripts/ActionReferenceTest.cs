using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
  This is a test of getting Actions/References from the editor
  As currently setup:
    Left Primary will fire ColorChange
    Either Secondary will do the same.
    Left hand trigger also.

   The left primary is specifically set to that Action. The other Action is 
   set to fire with either the left or right secondary button. 
   The left trigger is set to fire using an action reference. 
*/
public class ActionReferenceTest : MonoBehaviour
{
    // An attempt to rename the inspector text did not work.
    [InspectorName("Left Primary")] public InputAction leftPrimary;
     [InspectorName("Right Secondary")] public InputAction eitherSecondary;
    [SerializeField] private InputActionReference actionReference;
    [SerializeField] private GameObject actionObject;



    void Awake()
    {   
      
         leftPrimary.performed += ColorChange;
         eitherSecondary.performed += ColorChange;
         //TODO: give the trigger something better to do
         // Action references need to get the action first and then register the callback
         actionReference.action.performed += ColorChange;
    }
    

    private void OnEnable() {
      leftPrimary.Enable();
      eitherSecondary.Enable();
      actionReference.action.Enable();
    }
    private void OnDisable() {
      leftPrimary.performed -= ColorChange;
      eitherSecondary.performed -= ColorChange;
      actionReference.action.performed -= ColorChange;
    }

    private void ColorChange(InputAction.CallbackContext context) {
         // change to a random color
         Color color = new Color(Random.value,Random.value,Random.value,Random.value);
         actionObject.GetComponent<Renderer>().material.color = color;
    }

  
}
