using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    Rigidbody2D rBody;

    float maxBrushSize = 6;
    float minBrushSize = 1;

    float currentBrushSize = 1;

    private void Start(){
        rBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rBody.MovePosition((Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition));

        ChangeBrushSize();
    }

    void ChangeBrushSize(){
        if(Input.GetAxis("Mouse ScrollWheel") > 0f){
            Debug.Log("+++");
            currentBrushSize += 0.5f;
        }else if(Input.GetAxis("Mouse ScrollWheel") < 0f){
            currentBrushSize -= 0.5f;
            Debug.Log("---");
        }
        if(currentBrushSize > maxBrushSize){
            Debug.Log("+++ LIMITE");
            currentBrushSize = maxBrushSize;
        }
        if(currentBrushSize < minBrushSize){
            Debug.Log("--- LIMITE ");
            currentBrushSize = minBrushSize;
        }

        transform.localScale = new Vector3(currentBrushSize, currentBrushSize, 1);
    }
}
