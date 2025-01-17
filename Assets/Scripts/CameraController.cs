using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // ����� Update ���������� ���� ��� �� ����
    void Update()
    {
        // ���������, ������ �� ����� ������ ���� (0 - ����� ������ ����)
        if (Input.GetMouseButtonDown(0))
        {
            // ������� ���, ��������� �� ������ ����� ������� ���� �� ������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; // ������ ��� �������� ���������� � ����������� ���� � ��������

            // ���������, ���������� �� ��� �����-���� ��������� � �����
            if (Physics.Raycast(ray, out hit))
            {
                // ���������, ����� �� ������, � ������� ��������� ���, ��� "Animal"
                if (hit.collider.CompareTag("Animal"))
                {
                    // ���� ��� ���������, ������� ��������� � �������
                    Debug.Log("Animal");
                }
            }
        }
    }
}

