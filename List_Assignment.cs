using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public void FindPartyMember(string myName, int myNumber) //start from here for assignment
                                  //imput parameter 1 should be your own name, input parameter 2 should be the list where you want to be added
                                  // call this method from Start(), and print the whole list of players, you included
                                  //

                                  
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };




        QuestPartyMembers.Insert(myNumber, myName);
        Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

        for (int i = 0; i < QuestPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);
        }
    }

    public string myName = "Benny Bønne Mand";
    public int myNumber = 2;

        // Start is called before the first frame update
        void Start()
    {
        FindPartyMember(myName, myNumber);

        // for loop for  printing the whole list
        //have to be able to write the name in unity and it will add
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
