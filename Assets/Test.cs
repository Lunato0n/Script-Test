using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Chapter9.3
public class Boss
{
    private int hp = 100;
    private int power = 25;
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //Debug.Log("Hello, World");

    ////Chapter4.2
    // int score;
    // score = 150;
    // Debug.Log(score);

    ////Chapter4.3
    //int a = 3;
    //int b = 4;
    //int c = a + b;
    //Debug.Log(c);

    ////Chapter5.1
    //int money = 50;
    //if (money >= 100)
    //{
    //    Debug.Log("ポーションを買う");
    //}

    ////Chapter5.2
    //int money = 200;
    //if(money >= 100)
    //{
    //    Debug.Log("ポーションを買う");
    //}
    //else
    //{
    //    Debug.Log("武器を売る");
    //}

    ////Chapter5.3
    //int money = 30;
    //if (money <= 50)
    //{
    //    Debug.Log("武器を売る");
    //}
    //else if (money >= 200)
    //{
    //    Debug.Log("武器を買う");
    //}
    //else
    //{
    //    Debug.Log("ポーションを買う");
    //}

    ////Chapter5.4
    //int num = 2;
    //int val = (num == 1) ? -100 : 100;
    //Debug.Log(val);

    ////Chapter6
    //for(int i = 0; i < 7; i++)
    //{
    //    Debug.Log(i);
    //}

    ////Chapter6.1
    //int sum = 0;
    //for(int i = 1; i <= 10; i++ )
    //{
    //    sum += i;
    //}
    //Debug.Log(sum);

    ////Chapter7.3
    //string[] points = new string[5];
    //points[0] = "hare";
    //points[1] = "ame";
    //points[2] = "kumori";
    //points[3] = "yuki";
    //points[4] = "hyou";
    //for (int i = 0; i < 5; i++) 
    //{
    //    Debug.Log(points[i]);
    //}

    ////Chapter7.4
    //int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };
    //for (int i = 0; i < points.Length; i++)
    //{
    //    if (points[i] >= 50)
    //    {
    //        Debug.Log(points[i]);
    //    }
    //}

    ////Chapter8.1
    //void Goodbye()
    //{
    //    Debug.Log ("Goodbye, Unitychan");
    //}
    //void Start()
    //{
    //    Goodbye ();
    //}

    ////Chapter8.2
    //void HelloName(int name)
    //{
    //    Debug.Log("Hello," + name);
    //}
    //void Start()
    //{
    //    HelloName(938);
    //}

    ////Chapter8.3
    //int Add(int a, int b, int d)
    //{
    //    int c = a + b + d;
    //    return c;
    //}
    //private void Start()
    //{
    //    int num = Add(3, 6, 9);
    //    Debug.Log(num);
    //}

    //Chapter9.3
    private void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);

        Boss midboss = new Boss();
        midboss.Attack();
        midboss.Defence(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
