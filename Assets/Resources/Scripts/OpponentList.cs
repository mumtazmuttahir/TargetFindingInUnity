using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentList : MonoBehaviour
{

    GameObject[] allOpponents;

    private void Awake() {

        //https://docs.unity3d.com/ScriptReference/GameObject.FindGameObjectsWithTag.html
        allOpponents = GameObject.FindGameObjectsWithTag("Opponent");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] getOpponentsList() {
        return allOpponents;
    }
}
