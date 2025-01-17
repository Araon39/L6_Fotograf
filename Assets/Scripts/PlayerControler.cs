using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    // Метод Update вызывается один раз за кадр
    void Update()
    {
        // Устанавливаем скорость перемещения объекта
        float speed = 3f;

        // Устанавливаем скорость вращения объекта
        float rotationSpeed = 80;

        // Получаем горизонтальное, вертикальное и вращательное движение мыши
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseRotate = Input.GetAxis("Mouse X");

        // Перемещаем объект вперед с учетом скорости и вертикального ввода
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Mathf.Abs(vertical));

        // Вращаем объект вокруг оси Y с учетом скорости вращения и ввода мыши
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * (horizontal + mouseRotate));

        // Проверяем вертикальный ввод и изменяем значение blend
        if (vertical > 0) // Движение вперёд
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (vertical < 0) // Движение назад
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        // Устанавливаем значение blend для аниматора
        animator.SetFloat("Blend", Mathf.Abs(vertical));
    }
}
