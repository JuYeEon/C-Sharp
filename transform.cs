using UnityEngine;

public class transform : MonoBehaviour
{

    void Start(){
        Debug.Log(transform.position); //위치 출력
        transform.position = Vector2.one; // 1,1
        Vector2 pos = transform.position; //현재 위치를 pos에 저장
        pos.x += 3; // 현재위치 x값에 3을 더함
    }
}
