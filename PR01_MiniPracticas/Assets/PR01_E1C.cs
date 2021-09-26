using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PR01_E1C : MonoBehaviour
{
    public int VariableNum1 = 3;
    public int VariableNum2 = 5;
    public float VariableDecim = 3.4f;
    public bool VariableBool = true;
    [SerializeField] string VariableText1 = "Hola ";
    public string VariableText2 = "mundo";

    
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(VariableText1);
        print(VariableNum1 + VariableNum2);
        print(VariableText1 + VariableText2);

    }

// Update is called once per frame
void Update()
    {
        
}
}
