using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    // ����� Update ���������� ���� ��� �� ����
    void Update()
    {
        // ������������� �������� ����������� �������
        float speed = 3f;

        // ������������� �������� �������� �������
        float rotationSpeed = 80;

        // �������� ��������������, ������������ � ������������ �������� ����
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseRotate = Input.GetAxis("Mouse X");

        // ���������� ������ ������ � ������ �������� � ������������� �����
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Mathf.Abs(vertical));

        // ������� ������ ������ ��� Y � ������ �������� �������� � ����� ����
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * (horizontal + mouseRotate));

        // ��������� ������������ ���� � �������� �������� blend
        if (vertical > 0) // �������� �����
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (vertical < 0) // �������� �����
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        // ������������� �������� blend ��� ���������
        animator.SetFloat("Blend", Mathf.Abs(vertical));
    }
}
