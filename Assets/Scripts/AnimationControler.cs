using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationControler : MonoBehaviour
{
    // Объявляем переменную типа Animator и называем её monsterAnimator
    public Animator monsterAnimator;

    // Метод Update вызывается каждый кадр
    void Update()
    {
        // Проверяем, нажата ли клавиша W
        if (Input.GetKey(KeyCode.W))
        {
            // Если нажата, устанавливаем анимацию "Walk" и включаем её
            monsterAnimator.SetBool("Wallk", true);
        }
        // Проверяем, нажата ли клавиша E
        else if (Input.GetKey(KeyCode.E))
        {
            // Если нажата, запускаем триггер анимации "Attack"
            monsterAnimator.SetTrigger("Atack");
        }
        // Если ни одна из клавиш W и E не нажата
        else
        {
            // Отключаем анимацию "Walk"
            monsterAnimator.SetBool("Wallk", false);
        }
        
    }
}

