using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AngleJoystickControl : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private Image bgImg;
    private Vector2 inputVector;
    void Start()
    {
        bgImg = GetComponent<Image>();
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        JoystickControl(ped);

    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        JoystickControl(ped);
        inputVector = Vector2.zero;
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        JoystickControl(ped);
    }
    void JoystickControl(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / bgImg.rectTransform.sizeDelta.x);
            pos.y = (pos.y / bgImg.rectTransform.sizeDelta.y);
            inputVector = new Vector2(pos.x, pos.y);
            inputVector = new Vector2
                (Mathf.Clamp(inputVector.x, -1f, 1f), Mathf.Clamp(inputVector.y, -1f, 1f));
        }
    }
    public Vector2 GetAngleValue()
    {
        return inputVector;
    }
}
