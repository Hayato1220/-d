using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] CubePrefabs; //オブジェクトを格納する配列変数
    private float time; //出現する間隔を制御するための変数
    private int number; //ランダム情報を入れるための変数

    void Start()
    {
        time = 3.0f; //時間を待たず、最初の1回を出現
    }

    void Update()
    {
        time -= Time.deltaTime; //timeから時間を減らす
        if (time <= 0.0f) //0秒になれば
        {
            time = 3.0f; //1秒にする
            number = Random.Range(0, CubePrefabs.Length); //Random.Range (最小値, 最大値) 整数の場合は最大値は除外
            Instantiate(CubePrefabs[number], new Vector3(500, 79, 550), Quaternion.identity); //X座標-10にランダム出現、向きの設定は無し
        }
    }
}