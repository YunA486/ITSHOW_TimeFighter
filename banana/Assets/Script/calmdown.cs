using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calmdown : MonoBehaviour
{
    public GameObject CalmImg;
    // public GameObject CalmBackImg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        // Return == Enter Key
        {
            CalmImg.SetActive(true);
            // CalmBackImg.SetActive(true);
            Debug.Log("엔터 키 누름");
            // 이미지 띄운 다음에 일정 시간 지나면 삭제
            // Destroy(CalmImg, 5.0f);
            Invoke("hide", 5.0f);

        }
    }

    void hide()
    {
        CalmImg.SetActive(false);
        // CalmBackImg.SetActive(false);
    }
}
