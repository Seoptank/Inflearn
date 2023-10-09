using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCoroutine : MonoBehaviour
{
    //========================================================================================
    // �ڷ�ƾ ���� Update�θ� ������ ����
    //========================================================================================

    /*
    public bool     isDelay;
    public float    delayTime = 2f;

    private float   timer = 0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isDelay)
            {
                isDelay = true;
                Debug.Log("Attack");
            }
            else
            {
                Debug.Log("Delay");
            }
        }

        if(isDelay)
        {
            timer += Time.deltaTime;

            if(timer >= delayTime)
            {
                timer = 0;
                isDelay = false;
            }
        }
    }
     */

    //========================================================================================
    // �ڷ�ƾ �Լ��� ������ ����
    //========================================================================================
    public bool isDelay;
    public float delayTime = 2f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isDelay)
            {
                isDelay = true;
                Debug.Log("Attack");
                StartCoroutine("AttackDelay");
            }
            else
            {
                Debug.Log("Delay");
            }
        }
    }

    private IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(delayTime);
        isDelay = false;
    }

    // �ڷ�ƾ�� ����� �� ������ ��
    // 1. Start �Լ��� ȣ��� ����, GameObject�� Ȱ��ȭ�� ���Ŀ��� ���������� �۵���
    // 2. �ڷ�ƾ �ȿ��� ���ѷ��� �Ҷ� �ݺ��� ���ο� yield return;�� �����Ͽ� �ڷ�ƾ �Լ���
    //    ������� ������ ������ ���ߴ� ������ ����.
    //    ex)===============================
    //    private IEnumerator AttackDelay()
    //    {
    //        while(true)
    //        {
    //            yield return null;
    //        }
    //    }
    //    ==================================
}
