using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{

    public bool clear;
    // Start is called before the first frame update
    void Start()
    {
        clear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (clear == true)
        {
            SceneManager.LoadScene("GameClear");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")//衝突した相手のタグがEnemyなら
        {
            clear = true;
        }
    }
}
