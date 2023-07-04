using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRegister : MonoBehaviour
{
    public GameObject panel; // 패널을 가리키는 GameObject

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf); // 패널의 활성/비활성 상태를 반전시킴
    }
}
