using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        int a;
        a = 10;
        int b = 20;
        bool c = false;
        bool d = true;
        string e = "Programuję w C#";
        string f = "EPG";
        Equals(e, f);
        Debug.Log(a);
        {
            Debug.Log(b);
        }
        float fa = 1.5f;
        bool logic = true; //false
        string str = "napis";
        Debug.Log(" fa: " + fa + " logic: " + logic + " str: " + str);
        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        Debug.Log(a == b);//rowne
        Debug.Log(a != b);//rozne

        if(a != b)
        {
            Debug.Log("nir rowne");
        }else if (a==b) {
            Debug.Log("rowne");
        }else
        {
            Debug.Log("cos inne");
        }

        Debug.Log((a != b) && (a > 0));
        if ((a != b)&& (a > 0))
        {
            
        }
        if (!e.Equals(f))
        {
            Debug.Log("różne.");
        }

        int hp = 3, time = 1;
        bool aegis = true;
        if ((hp <= 0  && time <= 0) || aegis){
            Debug.Log("tak");
        }
        Task();
    }
    
    public void Task()
    {
        bool a = true, b = true, c = false, qwe, asd, zxc;
        if (a || b) { qwe = true; } else { qwe = false; }
        if (b || c) { asd = true; } else { asd = false; }
        if (a || c) { zxc = true; } else { zxc = false; }
        Debug.Log("Task" );
    }
}
