using UnityEngine;

public class CarController : MonoBehaviour
{

    // 【教本通り】------------------------------------------------------------------
    //float speed = 0;
    //Vector2 startPos;

    //void Start()
    //{
    //    Application.targetFrameRate = 60;

    //}

    //void Update()
    //{
    //    // スワイプの長さを求める
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        // マウスをクリックした座標
    //        this.startPos = Input.mousePosition;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        // マウスを離した座標
    //        Vector2 endPos = Input.mousePosition;
    //        float swipeLenght = endPos.x - this.startPos.x;

    //        // スワイプの長さを初速度に変換する
    //        this.speed = swipeLenght / 500.0f;

    //        // 効果音再生
    //        GetComponent<AudioSource>().Play();

    //    }

    //    transform.Translate(this.speed, 0, 0);
    //    this.speed *= 0.98f;
    //}
    // 【以上、教本通り】------------------------------------------------------------------



    // 【アレンジ】------------------------------------------------------------------
    float speed = 0;
    Vector2 startPos;

    // ボタン要素
    GameObject retryBtn;

    // 開始位置を記録
    Vector3 initialPosition;

    void Start()
    {
        Application.targetFrameRate = 60;

        // ボタン要素を取得、最初は非表示にする
        this.retryBtn = GameObject.Find("retry_btn");
        this.retryBtn.SetActive(false);

        // 初期位置を保存
        this.initialPosition = transform.position;
    }
    void Update()
    {
        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLenght = endPos.x - this.startPos.x;

            // スワイプの長さを初速度に変換する
            this.speed = swipeLenght / 500.0f;

            // 効果音再生
            //GetComponent<AudioSource>().Play();

            // 追加
            this.retryBtn.SetActive(true); // ボタン表示
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }

    // リトライボタンが押されたら初期位置に
    public void ResetPosition()
    {
        transform.position = this.initialPosition;
        this.speed = 0;
        this.retryBtn.SetActive(false);
    }
    // 【以上、アレンジ】------------------------------------------------------------------




    // 【アレンジ】------------------------------------------------------------------

    //float speed = 0;
    //Vector2 startPos;

    //// 最初の位置を記録
    //Vector3 initialPosition;

    //// スワイプの距離を回転の初速度に変換するためのスケーリング係数
    //// こういった数値は定数で管理すべき
    //private const float SwipeSpeedScale = 500.0f;

    //void Start()
    //{
    //    Application.targetFrameRate = 60;

    //    // ゲーム開始時の位置を保存
    //    initialPosition = transform.position;
    //}


    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        //this.speed = 0.2f;

    //        // マウスをクリックした座標
    //        this.startPos = Input.mousePosition;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        // マウスを離した座標
    //        Vector2 endPos = Input.mousePosition;
    //        float swipeLenght = endPos.x - this.startPos.x;

    //        // スワイプの長さを初速度に変換する
    //        this.speed = swipeLenght / SwipeSpeedScale;
    //    }

    //    // 右クリックで位置リセット
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        transform.position = initialPosition;
    //        speed = 0; // 動きも止める
    //    }


    //    transform.Translate(this.speed, 0, 0);
    //    this.speed *= 0.98f;
    //}



}
