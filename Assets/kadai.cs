using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //��1�@�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] array = { 1, 3, 5, 9, 17 };
        //��2�@for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        for (int i = 0; i < 5; i++) 
        {
            Debug.Log(array[i]);
        }
        //��3�@for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������
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
