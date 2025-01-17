using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoCamera : MonoBehaviour
{
    // ������ ����, ������� ����� �������������� � ����������������
    public GameObject photo;

    // ����� Update ���������� ���� ��� �� ����
    void Update()
    {
        // ���������, ������ �� ������� "F"
        if (Input.GetKey(KeyCode.F))
        {
            // ���������� ������ ����
            photo.SetActive(true);
        }
        // ���������, ������ �� ������� "Escape"
        else if (Input.GetKey(KeyCode.Escape))
        {
            // ������������ ������ ����
            photo.SetActive(false);
        }
    }
}
