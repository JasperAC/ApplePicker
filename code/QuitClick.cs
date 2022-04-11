using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuitClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData evenData)
    {
        Application.Quit();
    }

}
