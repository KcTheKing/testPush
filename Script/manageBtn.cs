using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class manageBtn : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public Transform player,minPos,maxPos;
    public float RL;
    bool isClick;
    public Transform transform;
    private void Update()
    {
        if (isClick)
        {
            player.Translate(RL * Time.deltaTime,0,0); 
        }
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minPos.position.x, maxPos.position.x);
        transform.position = pos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isClick = true;
    }

    public void OnPointerUp(PointerEventData eventData) 
    { 
        isClick = false;
    }

}
