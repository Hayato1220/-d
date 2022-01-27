using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    Slider hpSlider;
    public GameObject slider;
    bool heel;

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

        heel = false;
    }
    void Update()
    {

        hpSlider.value -= 1f;

        if (hpSlider.value <= 0)//もしhpが0以下なら
        {
            SceneManager.LoadScene("GameOver");//some_senseiシーンをロードする        
        }

        if(heel == true && Input.GetButton("pad"))
        {
            hpSlider.value += 5;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boulder")//衝突した相手のタグがEnemyなら
        {
            hpSlider.value -= 250;//hpを-1ずつ変える
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "kaihuku")
        {
            heel = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "kaihuku")
        {
            heel = false; 
        }
    }
}
