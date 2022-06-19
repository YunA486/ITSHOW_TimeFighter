using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    [SerializeField]
    InputField inputField;
    public int lastpoint;

    int[] number = new int[5];

    public void Save()
    {
        lastpoint = GameObject.Find("ScoreManager").GetComponent<ScoreManager>().stagePoint;
        /*PlayerPrefs.SetString("Name", inputField.text);
        PlayerPrefs.SetInt("Score", lastpoint);*/

        /*for(int i = 0; i <= number.Length; i++)
        {
            number[i] += 
        }*/

        PlayerPrefs.SetInt(inputField.text, lastpoint);
        /* inputField에 이름 입력하면 그 이름으로 점수 저장 */

    }

    public void Load()
    {
        /*inputField1.text = PlayerPrefs.GetString(inputField.text);*/
        lastpoint = PlayerPrefs.GetInt(inputField.text);
        /* inputfield에 키값 입력하면 점수 나옴 */

        Debug.Log(lastpoint);

        /* 배열에 점수 저장 */
        number[0] = lastpoint;
        Debug.Log(number[0]);
        Debug.Log(lastpoint);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
