using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public Slider timeSlider,forceSlider;
    public GameObject HorizontalBall;
    Rigidbody rb;
    bool check;
    void Start()
    {
        rb = HorizontalBall.GetComponent<Rigidbody>();
        Time.timeScale = 0f;
    }
    void Update()
    {
        if(check) Time.timeScale = timeSlider.value;
    }

    public void DropBall()
    {
        check = true;
        Time.timeScale = timeSlider.value;
        rb.AddForce(4 * forceSlider.value, 0, 0, ForceMode.Impulse);
    }
    public void ResetBall()
    {
        SceneManager.LoadScene(0);
    }
}
