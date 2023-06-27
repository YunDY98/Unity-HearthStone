using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Inst { get; private set; }
    void Awake() => Inst = this;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
            InputCheatKey();
        #endif
        
    }
    void InputCheatKey()
    {
           //          맥용 1번 이벤트                        윈도우용 1번 이벤트 
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            TurnManager.OnAddCard?.Invoke(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            TurnManager.OnAddCard?.Invoke(false);
        }
    }

    public void StartGame()
    {
        StartCoroutine(TurnManager.Inst.StartGameCo());
    }
}
