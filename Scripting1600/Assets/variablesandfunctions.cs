using UnityEngine;
using System.Collections;

public class variablesandfunctions : MonoBehaviour {
    int myint = 5;

    // Use this for initialization
    void Start() {
        myint = multiplybytwo(myint);
        Debug.Log(myint);

    }

    // Update is called once per frame
    int multiplybytwo(int number)
    {     int ret;
    ret = number* 2;
        return ret;
        }
	
	}

