using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    Slider hpSlider;
    public GameObject slider;

    // Use this for initialization
    void Start()
    {

        hpSlider = slider.GetComponent<Slider>();

        float maxHp = 5000f;
        float nowHp = 5000f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;


    }

    // Update is called once per frame
    void Update()
    {
        hpSlider.value -= 1f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boulder")//衝突した相手のタグがEnemyなら
        {
            hpSlider.value -= 250f;
        }

        if (hpSlider.value < 1)//もしhpが0以下なら
        {
            print("GameOver");//GameOverとコンソールに表示する
        }
    }
}
