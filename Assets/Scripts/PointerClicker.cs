using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PointerClicker : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent onLeftClick;
    public UnityEvent onMiddleClick;
    public UnityEvent onRightClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (eventData.button)
        {
            case PointerEventData.InputButton.Left:
                onLeftClick.Invoke();
                break;
            case PointerEventData.InputButton.Middle:
                onMiddleClick.Invoke();
                break;
            case PointerEventData.InputButton.Right:
                onRightClick.Invoke();
                break;
        }
    }
}
