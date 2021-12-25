using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class ControllerDebug : MonoBehaviour
{
    public int speed;
    private InputDevice targetDevice;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerChar = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerChar,devices);
       // InputDevices.GetDevices(devices);

        foreach (var item in devices)
        {
          Debug.Log(item.name + item.characteristics);
        }
        if(devices.Count > 0) {
            targetDevice = devices[0];

        } else { Debug.Log("Fuck You 3");}
       
    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton,out bool primaryButtonValue);
        if(primaryButtonValue) {
            Debug.Log("pressing primar button");
        }

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if(triggerValue > 0.1f)
            Debug.Log("Trigger Pressed " + triggerValue);

        targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue);
        if(primary2DAxisValue != Vector2.zero)
            Debug.Log("Primary Touchpad " + primary2DAxisValue);

    }
}
