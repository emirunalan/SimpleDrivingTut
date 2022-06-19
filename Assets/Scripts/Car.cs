using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{

    [SerializeField] float speed = 10f;
    [SerializeField] float speedGainPerSecond = 1;
    [SerializeField] float turnSpeed = 200f;

    int steerValue;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += speedGainPerSecond * Time.deltaTime;

        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            int activeScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeScene);
        }
    }



    public void Steer(int value)
    {
        steerValue = value;
    }
}
