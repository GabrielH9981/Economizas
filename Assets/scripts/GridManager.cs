using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public GameObject pixelObject;

    public int gridSize = 64;
    public List<SpriteRenderer> pixels;
    public List<Color> finalColours;
    public Color currentColour = Color.black;
    public List<Color> correctColours;

    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
        pixels = new List<SpriteRenderer>();

        for (int i=0; i<gridSize; i++){
            for (int j=0; j<gridSize; j++){
                GameObject obj = Instantiate(pixelObject, new Vector3(i, j, 0), Quaternion.identity, transform);
                pixels.Add(obj.GetComponent<SpriteRenderer>());
            }
        }
    }

    public void SubmitColours(){
        finalColours = new List<Color>();
        //correctColours = new List<Color>();
        for (int i=0; i<pixels.Count; i++){
            finalColours.Add(pixels[i].color);
            //correctColours.Add(pixels[i].color);
        }
    }

    public void CheckColours(){
        int amountCorrect = 0;
        for (int i=0; i<pixels.Count; i++){
            if(pixels[i].color == correctColours[i]){
                amountCorrect ++;
            }
        }

        float percent = (float)amountCorrect / pixels.Count;
        print("You got " + percent + " correct");
    }

    public void SetPencilColour(Image thisColour){
        currentColour = thisColour.color;
    }

    public Color GetCurrentColour(){
        return currentColour;
    }
}
