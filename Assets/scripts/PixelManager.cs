using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelManager : MonoBehaviour
{
    SpriteRenderer sRend;

    private void Start(){
        sRend = GetComponent<SpriteRenderer>();
    }

   

    //private void OnMouseOver(){
        //Debug.Log("Worked OnMouseOver");
    //}

    private void OnTriggerStay2D(Collider2D collision){
        if (collision.CompareTag("Brush")){
            if(Input.GetMouseButton(0)){
            //Debug.Log("Pressed left click.");
            sRend.color = transform.parent.GetComponent<GridManager>().GetCurrentColour();
            }
        }
    }
}
