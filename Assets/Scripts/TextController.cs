using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class TextController : MonoBehaviour {

    public Text text;
    enum state {intro,strange_room_0,window_0,lock_0,lever_0,strange_room_1,lock_1,window_1,lever_1,corridor_0,
                backwall_0,frontwall_0,floor_0,corridor_1,backwall_1,frontwall_1,floor_1,
                corridor_2,backwall_2,frontwall_2,floor_2,wrong,final }
        state myState;
	void Start () {
        myState = state.intro;
	}
	
	
	void Update () {
        print(myState);
        if (myState == state.intro)             { Intro(); }
        if (myState==state.strange_room_0)      { strage_room_0(); }
        if (myState == state.window_0)          { window_0(); }
        if (myState == state.lock_0)            { lock_0(); }
        if (myState == state.lever_0)           { lever_0(); }
        if (myState == state.strange_room_1)    { strange_room_1(); }
        if (myState == state.lock_1)            { lock_1(); }
        if (myState == state.lever_1)           { lever_1(); }
        if (myState == state.window_1)          { window_1(); }
        if (myState == state.corridor_0)        { corridor_0(); }
        if (myState == state.backwall_0)        { backwall_0(); }
        if (myState == state.frontwall_0)       { frontwall_0(); }
        if (myState == state.floor_0)           { floor_0(); }
        if (myState == state.corridor_1)        { corridor_1(); }
        if (myState == state.backwall_1)        { backwall_1(); }
        if (myState == state.frontwall_1)       { frontwall_1(); }
        if (myState == state.floor_1)           { floor_1(); }
        if (myState == state.corridor_2)        { corridor_2(); }
        if (myState == state.backwall_2)        { backwall_2(); }
        if (myState == state.frontwall_2)       { frontwall_2(); }
        if (myState == state.floor_2)           { floor_2(); }
        if (myState == state.final)             { final(); }
        if (myState  == state.wrong)            { wrong(); }

    }

    private void wrong()
    {
        text.text = "What the...!? Said I as I fell trough the floor.This is the same room I woke up!\n\n" +
                    "Press S to Start Over.";
        if (Input.GetKeyDown(KeyCode.S))
            myState = state.strange_room_0;
    }

    private void frontwall_2()
    {
            text.text = "Now what should I do???\n\n" +
                        "Press R to Return       \n" +
                        "Press P to Put the Brick";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_2;
        if (Input.GetKeyDown(KeyCode.P))
            myState = state.wrong;
    }

    private void floor_2()
    {
        text.text = "I have to green brick, should I keep it? should I put it back? shoud I switch it?\n\n" +
                    "Press R to Return            \n" +
                    "Press K to pick the Red Brick\n" +
                    "Press P to Put it back       ";

        if (Input.GetKeyDown(KeyCode.P))
            myState = state.corridor_0;
        if (Input.GetKeyDown(KeyCode.K))
            myState = state.corridor_1;
        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_2;
    }

    private void backwall_2()
    {
        text.text = "Whyyy did I look back, there's nothing here!!!\n\n" +
                    "Press R to Return";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_2;
    }

    private void corridor_2()
    {
        text.text = "I picked the green brick, but is it the right one???\n\n" +
                    "Press F to look at the Floor     \n" +
                    "Press B to look at the Back wall \n" +
                    "Press W to look at the Front wall";

        if (Input.GetKeyDown(KeyCode.F))
            myState = state.floor_2;
        if (Input.GetKeyDown(KeyCode.B))
            myState = state.backwall_2;
        if (Input.GetKeyDown(KeyCode.W))
            myState = state.frontwall_2;
    }

    private void final()
    {
        text.text = "Hurray... It opened a portal, but will he teleport back to home???\n " +
                    "Congratulations!!!\n\n" +
                    "TO BE CONTINUE\n\n" +
                    "Press S to Start Over";

        if (Input.GetKeyDown(KeyCode.S))
            myState = state.intro;
    }

    private void floor_1()
    {
            text.text = "I have to red brick, should I keep it? should I put it back? shoud I switch it?\n\n" +
                        "Press G to pick the Green Brick\n" +
                        "Press P to Put it back          \n" +
                        "Press R to Return              ";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_1;
        if (Input.GetKeyDown(KeyCode.G))
            myState = state.corridor_2;
        if (Input.GetKeyDown(KeyCode.P))
            myState = state.corridor_0;
    }

    private void frontwall_1()
    {
            text.text = "That's strage ... the hole disappeared. There must be somewhere else then.\n\n" +
                        "Press R to Return";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_1;
      
    }

    private void backwall_1()
    {
            text.text = "Wow...Now there's a hole in it too!!!\n\n" +
                        "Press P to Put the Brick\n" +
                        "Press R to Return       ";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_1;
        if (Input.GetKeyDown(KeyCode.P))
            myState = state.final;
    }

    private void corridor_1()
    {
            text.text = "I picked the red brick, but is it the right one???\n\n" +
                        "Press F to look at the Floor     \n" +
                        "Press B to look at the Back Wall \n" +
                        "Press W to look at the Front Wall";

        if (Input.GetKeyDown(KeyCode.F))
            myState = state.floor_1;
        if (Input.GetKeyDown(KeyCode.B))
            myState = state.backwall_1;
        if (Input.GetKeyDown(KeyCode.W))
            myState = state.frontwall_1;
    }

    private void floor_0()
    {
            text.text = "Look... I found two bricks! But which one is it???" +
                        "One's red, one's green. These might come in hand.\n\n " +
                        "Press K to pick the Red Brick   \n" +
                        "Press G to pick the Green Brick\n" +
                        "Press R to Return              ";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_0;
        if (Input.GetKeyDown(KeyCode.K))    // B=Red brick
            myState = state.corridor_1;
        if (Input.GetKeyDown(KeyCode.G))   //  G=Green brick
            myState = state.corridor_2;
    }

    private void backwall_0()
    {
            text.text = "There's nothing here, I must look somewhere else!\n\n" +
                        "Press R to Return";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_0;
    }

    private void frontwall_0()
    {
            text.text = "There's a hole in it.It seems like a rectagle shape!" +
                        "There must be something out there, that fits that shape. \n\n" +
                        "Press R to Return";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.corridor_0;

    }

    private void corridor_0()
    {
        text.text = "That's strange...I looked back but the door disappeared! \n" +
                    "There's no turning back now. What's whappening???" +
                    " This room has no doors ... JUST WALLS!!!" +
                    " \n \n" +
                    "Press F to look at the Floor     \n" +
                    "Press W to look at the Front Wall\n" +
                    "Press B to look at the Back Wall \n";

        if (Input.GetKeyDown(KeyCode.F))
            myState = state.floor_0;
        if (Input.GetKeyDown(KeyCode.W)) 
            myState = state.frontwall_0;
        if (Input.GetKeyDown(KeyCode.B))   
            myState = state.backwall_0;


    }

    private void window_1()
    {
        text.text = "Wow , what a nice view but...I've seen that before , a few moments ago... \n" +
                    "There's nothing I can use here. \n \n" +
                    "Press R to Return";
        if (Input.GetKeyDown(KeyCode.R))
            myState = state.strange_room_1;
    }

    private void lever_1()
    {
        text.text = "Hmm... Shoud I pull it back??? .\n \n" +
                      "Press R to Return\n" +
                      "Press P to Push  ";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.strange_room_1;
        if (Input.GetKeyDown(KeyCode.P))
            myState = state.strange_room_0;
    }

    private void lock_1()
    {
        text.text = "It's open , now it's my chance to escape.\n" +
                    "What's that green light behind the door??? I'm affraid! .\n \n" +
                    "Press R to Return\n" +
                    "Press O to Open  ";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.strange_room_1;
        if (Input.GetKeyDown(KeyCode.O))
            myState = state.corridor_0;
    }

    private void strange_room_1()
    {
        text.text = "Okey... Let's keep looking , I think I made something! \n \n " +
                    "Press W to look at the Window\n" +
                    "Press K to look at the Lock  \n" +
                    "Press L to look at the Lever ";

        if (Input.GetKeyDown(KeyCode.W))
            myState = state.window_1;
        if (Input.GetKeyDown(KeyCode.K))
            myState = state.lock_1;
        if (Input.GetKeyDown(KeyCode.L))
            myState = state.lever_1;
    }

    private void lever_0()
    {
        text.text = "Yeahhh...I found it.This must be the device that opens the lock.\n \n" +
                    "Press R to Return\n" +
                    "Press P to Pull  ";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.strange_room_0;
        if (Input.GetKeyDown(KeyCode.P))
            myState = state.strange_room_1;
    }

    private void lock_0()
    {
        text.text = "Hmmm...it seems locked and I can't open it with my bare hands.\n" +
                    "It must be a device somewhere around here.I'm gonna look for it.\n \n"+
                    "Press R to Return";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.strange_room_0;
    }

    private void window_0()
    {
        text.text = "Wow , what a nice view , I never seen something like that before. \n" +
                    "Unfortunately there's nothing I can use here. \n \n" +
                    "Press R to Return";

        if (Input.GetKeyDown(KeyCode.R))
            myState = state.strange_room_0;
    }

    private void strage_room_0()
    {
        text.text = "Get out of your bed and let's begin the adventure! \n"+
                    "Let's look for some objects! \n \n " +
                    "Press W to look at the Window\n" +
                    "Press K to look at the Lock  \n" +
                    "Press L to look at the Lever ";

        if (Input.GetKeyDown(KeyCode.W)) 
        myState = state.window_0;
        if (Input.GetKeyDown(KeyCode.K)) 
        myState = state.lock_0;
        if (Input.GetKeyDown(KeyCode.L)) 
        myState = state.lever_0;

    }

    void Intro()
    {
        text.text = "You woke up this morning and realised that you are no longer in your realm." +
                    "You are trapped in an unknown dimension.Your task is to find your way back."+    
                    "Search in the room for objects that can be useful.\n" +
                    "Good luck!!!" +
                     "\n \n Press Space to Start Game";

        if (Input.GetKeyDown(KeyCode.Space))
        
            myState = state.strange_room_0;
       
    }
}
