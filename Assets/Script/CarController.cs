using UnityEngine;

public class CarController : MonoBehaviour
{

    // �y���{�ʂ�z------------------------------------------------------------------
    //float speed = 0;
    //Vector2 startPos;

    //void Start()
    //{
    //    Application.targetFrameRate = 60;

    //}

    //void Update()
    //{
    //    // �X���C�v�̒��������߂�
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        // �}�E�X���N���b�N�������W
    //        this.startPos = Input.mousePosition;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        // �}�E�X�𗣂������W
    //        Vector2 endPos = Input.mousePosition;
    //        float swipeLenght = endPos.x - this.startPos.x;

    //        // �X���C�v�̒����������x�ɕϊ�����
    //        this.speed = swipeLenght / 500.0f;

    //        // ���ʉ��Đ�
    //        GetComponent<AudioSource>().Play();

    //    }

    //    transform.Translate(this.speed, 0, 0);
    //    this.speed *= 0.98f;
    //}
    // �y�ȏ�A���{�ʂ�z------------------------------------------------------------------



    // �y�A�����W�z------------------------------------------------------------------
    float speed = 0;
    Vector2 startPos;

    // �{�^���v�f
    GameObject retryBtn;

    // �J�n�ʒu���L�^
    Vector3 initialPosition;

    void Start()
    {
        Application.targetFrameRate = 60;

        // �{�^���v�f���擾�A�ŏ��͔�\���ɂ���
        this.retryBtn = GameObject.Find("retry_btn");
        this.retryBtn.SetActive(false);

        // �����ʒu��ۑ�
        this.initialPosition = transform.position;
    }
    void Update()
    {
        // �X���C�v�̒��������߂�
        if (Input.GetMouseButtonDown(0))
        {
            // �}�E�X���N���b�N�������W
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // �}�E�X�𗣂������W
            Vector2 endPos = Input.mousePosition;
            float swipeLenght = endPos.x - this.startPos.x;

            // �X���C�v�̒����������x�ɕϊ�����
            this.speed = swipeLenght / 500.0f;

            // ���ʉ��Đ�
            //GetComponent<AudioSource>().Play();

            // �ǉ�
            this.retryBtn.SetActive(true); // �{�^���\��
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }

    // ���g���C�{�^���������ꂽ�珉���ʒu��
    public void ResetPosition()
    {
        transform.position = this.initialPosition;
        this.speed = 0;
        this.retryBtn.SetActive(false);
    }
    // �y�ȏ�A�A�����W�z------------------------------------------------------------------




    // �y�A�����W�z------------------------------------------------------------------

    //float speed = 0;
    //Vector2 startPos;

    //// �ŏ��̈ʒu���L�^
    //Vector3 initialPosition;

    //// �X���C�v�̋�������]�̏����x�ɕϊ����邽�߂̃X�P�[�����O�W��
    //// �������������l�͒萔�ŊǗ����ׂ�
    //private const float SwipeSpeedScale = 500.0f;

    //void Start()
    //{
    //    Application.targetFrameRate = 60;

    //    // �Q�[���J�n���̈ʒu��ۑ�
    //    initialPosition = transform.position;
    //}


    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        //this.speed = 0.2f;

    //        // �}�E�X���N���b�N�������W
    //        this.startPos = Input.mousePosition;
    //    }
    //    else if (Input.GetMouseButtonUp(0))
    //    {
    //        // �}�E�X�𗣂������W
    //        Vector2 endPos = Input.mousePosition;
    //        float swipeLenght = endPos.x - this.startPos.x;

    //        // �X���C�v�̒����������x�ɕϊ�����
    //        this.speed = swipeLenght / SwipeSpeedScale;
    //    }

    //    // �E�N���b�N�ňʒu���Z�b�g
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        transform.position = initialPosition;
    //        speed = 0; // �������~�߂�
    //    }


    //    transform.Translate(this.speed, 0, 0);
    //    this.speed *= 0.98f;
    //}



}
