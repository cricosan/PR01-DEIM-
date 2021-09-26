using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PR01_E2A : MonoBehaviour
{
    private int VariableNum = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (VariableNum <= 5)
        {
            print(VariableNum);
            VariableNum++;
        }
        else if (VariableNum > 5 && VariableNum < 12)
        {
            print(VariableNum);
            VariableNum++;
            VariableNum++;
        }
    }
}
