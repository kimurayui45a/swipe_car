using UnityEngine;
using TMPro;  // TextMeshPro

public class GameDirector : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;


    void Start()
    {
        // Findメソッド：引数名と一致するオブジェクトがゲームシーンの中にある場合それを取得する
        this.car = GameObject.Find("car_0");
        this.flag = GameObject.Find("flag_0");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length >= 0)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "GameOver";
        }
    }
}
