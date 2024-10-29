using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string [] words ={"Cat","Dog","Car","Pizza","Hat","Fish","Tree","Monkey","Ball","Bird"};
        string funnysentence="";
        int count=0;

        while(count < 7 )
        {
            int random=Random.Range(0,words.Length);
            funnysentence += words[random];
            count++;
        }
        Debug.Log(funnysentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
