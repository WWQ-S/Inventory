using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Iinventory : MonoBehaviour
{
    public Canvas canvas;
    Image[,] inventorySlots = new Image[10,10];
    public Image refImage;
    public Image inventoryBackGround;

    void Start()
    {   float heightImage = inventoryBackGround.rectTransform.rect.height/10;
        float widthImage = inventoryBackGround.rectTransform.rect.width / 10;
        refImage.rectTransform.sizeDelta = new Vector2(widthImage, heightImage);

        int heightM = inventorySlots.GetLength(0);
        int widthM = inventorySlots.GetLength(1);
       
        float X = inventoryBackGround.transform.position.x + widthImage/4;
        float Y = inventoryBackGround.transform.position.y + heightImage/4;

        for (int i = 0; i < heightM; i++)
        {            
            for (int j = 0; j < widthM; j++)
            {                                   
                Instantiate(refImage, new Vector3 (X, Y, 1), Quaternion.Euler(0f,0f,0f), inventoryBackGround.transform);

                X +=51;
            }
            Y += 51;
            X = inventoryBackGround.transform.position.x + widthImage / 4;
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
