using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public string Content;
    public string Header;

    public void OnPointerEnter (PointerEventData eventData)
    {
        TooltipSystem.Show (Content, Header);
    }

    public void OnPointerExit (PointerEventData eventData)
    {
        TooltipSystem.Hide ();
    }
}