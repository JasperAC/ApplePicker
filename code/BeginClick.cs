using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BeginClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData evenData)
    {
        SceneManager.LoadScene("Scene0");
    }

}
