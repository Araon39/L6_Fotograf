using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoCamera : MonoBehaviour
{
    // Объект фото, который будет активироваться и деактивироваться
    public GameObject photo;

    // Метод Update вызывается один раз за кадр
    void Update()
    {
        // Проверяем, нажата ли клавиша "F"
        if (Input.GetKey(KeyCode.F))
        {
            // Активируем объект фото
            photo.SetActive(true);
        }
        // Проверяем, нажата ли клавиша "Escape"
        else if (Input.GetKey(KeyCode.Escape))
        {
            // Деактивируем объект фото
            photo.SetActive(false);
        }
    }
}
