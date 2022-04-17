using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public GameObject pixelObject;

    public int gridSize = 100;
    public List<GameObject> pixels;

    public Color currentColour = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
        pixels = new List<GameObject>();

        for (int i=0; i<gridSize; i++){
            for (int j=0; j<gridSize; j++){
                GameObject obj = Instantiate(pixelObject, new Vector3(i, j, 0), Quaternion.identity, transform);
                pixels.Add(obj);
            }
        }
    }

    public void SetPencilColour(Image thisColour){
        currentColour = thisColour.color;
    }

    public Color GetCurrentColour(){
        return currentColour;
    }
}
