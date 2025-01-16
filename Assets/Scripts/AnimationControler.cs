using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationControler : MonoBehaviour
{
    // ��������� ���������� ���� Animator � �������� � monsterAnimator
    public Animator monsterAnimator;

    // ����� Update ���������� ������ ����
    void Update()
    {
        // ���������, ������ �� ������� W
        if (Input.GetKey(KeyCode.W))
        {
            // ���� ������, ������������� �������� "Walk" � �������� �
            monsterAnimator.SetBool("Wallk", true);
        }
        // ���������, ������ �� ������� E
        else if (Input.GetKey(KeyCode.E))
        {
            // ���� ������, ��������� ������� �������� "Attack"
            monsterAnimator.SetTrigger("Atack");
        }
        // ���� �� ���� �� ������ W � E �� ������
        else
        {
            // ��������� �������� "Walk"
            monsterAnimator.SetBool("Wallk", false);
        }
        
    }
}

