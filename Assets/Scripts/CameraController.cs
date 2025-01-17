using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Метод Update вызывается один раз за кадр
    void Update()
    {
        // Проверяем, нажата ли левая кнопка мыши (0 - левая кнопка мыши)
        if (Input.GetMouseButtonDown(0))
        {
            // Создаем луч, исходящий от камеры через позицию мыши на экране
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; // Объект для хранения информации о пересечении луча с объектом

            // Проверяем, пересекает ли луч какой-либо коллайдер в сцене
            if (Physics.Raycast(ray, out hit))
            {
                // Проверяем, имеет ли объект, с которым пересекся луч, тег "Animal"
                if (hit.collider.CompareTag("Animal"))
                {
                    // Если тег совпадает, выводим сообщение в консоль
                    Debug.Log("Animal");
                }
            }
        }
    }
}

