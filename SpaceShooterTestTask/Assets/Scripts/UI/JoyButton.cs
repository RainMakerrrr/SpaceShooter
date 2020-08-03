using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    private bool _isPressed;

    public bool IsPressed => _isPressed;

    public void OnPointerDown(PointerEventData eventData) => _isPressed = true;

    public void OnPointerUp(PointerEventData eventData) => _isPressed = false;
    
}
