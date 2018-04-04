using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Img : MonoBehaviour
{
    public Texture2D myImg; // 從外部拖拉自己喜歡的圖片進來

    private void Awake()
    {
        Sprite s = Sprite.Create(myImg, new Rect(0, 0, myImg.width, myImg.height), Vector2.zero);
        GetComponent<Image>().sprite = s;
    }
}