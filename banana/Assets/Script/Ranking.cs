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
        /* inputField�� �̸� �Է��ϸ� �� �̸����� ���� ���� */

    }

    public void Load()
    {
        /*inputField1.text = PlayerPrefs.GetString(inputField.text);*/
        lastpoint = PlayerPrefs.GetInt(inputField.text);
        /* inputfield�� Ű�� �Է��ϸ� ���� ���� */

        Debug.Log(lastpoint);

        /* �迭�� ���� ���� */
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
