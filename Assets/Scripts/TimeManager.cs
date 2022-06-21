using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeManager : MonoBehaviour
{
    public Text txt_timeFloored;
    public float elapsedTime;
    public bool isCounting;


    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isCounting = false;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        txt_timeFloored.text = Mathf.Floor(currentTime).ToString();

        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
        }
        if (currentTime > 100)
        {
            SceneManager.LoadScene("Cartel_De_Perdiste");
        }

    }
}
