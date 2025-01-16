using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private int speed = 20; // Скорость движения игрока
    public float horizontal; // Горизонтальное направление движения
    public float vertical;   // Вертикальное направление движения

    // Метод Update вызывается один раз за кадр
    void Update()
    {
        // Получаем значения осей от клавиатуры или геймпада
        horizontal = Input.GetAxis("Horizontal"); // Горизонтальное направление (влево/вправо)
        vertical = Input.GetAxis("Vertical");   // Вертикальное направление (вверх/вниз)

        //Движение игрока
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        //Поворот игрока
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
    }
}
