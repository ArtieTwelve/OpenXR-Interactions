using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionReferenceTest : MonoBehaviour
{
    [SerializeField] private InputAction leftPrimary, rightPrimary;
    [SerializeField] private InputActionReference actionReference;
    [SerializeField] private GameObject actionObject;



    void Awake()
    {   // INPUTASSET BindingTreeItem{"m_Name":"","m_Id":"a1d431af-aba3-4f4c-a243-924d9987239f","m_Path":"<XRController>{LeftHand}/primaryButton","m_Interactions":"","m_Processors":"","m_Groups":"","m_Action":"Primary","m_Flags":0}
        leftPrimary = new InputAction(name:"PrimaryButtons",binding: "<XRController>{LeftHand}/primaryButton");
        leftPrimary.Enable();
        leftPrimary.performed += ColorChange;//  {Debug.Log("Button Click: name: " + context.phase);};

        rightPrimary = new InputAction(name:"PrimaryButtons",binding: "<XRController>{RightHand}/primaryButton");
        rightPrimary.Enable();
        rightPrimary.performed += ColorChangeBack;
    }

    private void ColorChange(InputAction.CallbackContext context) {
         // GetComponent<Renderer>().material.color = Color.grey;
         actionObject.GetComponent<Renderer>().material.color = Color.grey;
    }

    private void ColorChangeBack(InputAction.CallbackContext context) {
         // GetComponent<Renderer>().material.color = Color.grey;
         actionObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
