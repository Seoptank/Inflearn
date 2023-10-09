using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCoroutine : MonoBehaviour
{
    //========================================================================================
    // 코루틴 없이 Update로만 딜레이 구현
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
    // 코루틴 함수로 딜레이 구현
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

    // 코루틴을 사용할 때 주의할 점
    // 1. Start 함수가 호출된 이후, GameObject가 활성화된 이후에만 정상적으로 작동함
    // 2. 코루틴 안에서 무한루프 할때 반복문 내부에 yield return;을 삽입하여 코루틴 함수가
    //    제어권을 가져가 게임이 멈추는 현상을 방지.
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
