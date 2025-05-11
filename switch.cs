using UnityEngine;

public class 1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 1;
        switch(num){
            case 1:
                Debug.Log("값이 1입니다.");
            break;
            case 2:
                Debug.Log("값이 2입니다.");
            break;
            default:
                Debug.Log("다 아님");
            break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
