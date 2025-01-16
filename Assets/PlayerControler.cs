using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private int speed = 20; // �������� �������� ������
    public float horizontal; // �������������� ����������� ��������
    public float vertical;   // ������������ ����������� ��������

    // ����� Update ���������� ���� ��� �� ����
    void Update()
    {
        // �������� �������� ���� �� ���������� ��� ��������
        horizontal = Input.GetAxis("Horizontal"); // �������������� ����������� (�����/������)
        vertical = Input.GetAxis("Vertical");   // ������������ ����������� (�����/����)

        //�������� ������
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        //������� ������
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
    }
}
