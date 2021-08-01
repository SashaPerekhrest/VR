using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Valve.VR.InteractionSystem;

public class Rotate : MonoBehaviour
{
    public HoverButton hoverButton;
    public UnityEvent action;
    void Start()
    {
        hoverButton.onButtonDown.AddListener(OnButtonDown);
    }

    private void OnButtonDown(Hand hand)
    {
        action.Invoke();
    }

    public void MoveUp()
    {
        transform.eulerAngles += new Vector3(0f, 0f, 45f);
    }
    public void MoveDown()
    {
        
    }
}
