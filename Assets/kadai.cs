using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //問1　要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 1, 3, 5, 9, 17 };
        //問2　for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < 5; i++) 
        {
            Debug.Log(array[i]);
        }
        //問3　for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = array.Length - 1; i >= 0; i--) 
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
