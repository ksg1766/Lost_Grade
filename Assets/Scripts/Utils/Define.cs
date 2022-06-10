using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum WorldObject
    {
        Unknown,
        Player,
        Monster,
    }

    public enum State
    {
        Die,
        Moving,
        Idle,
        Skill,
        Skill1,
    }

    public enum Layer
    {
        Monster = 8,
        Ground = 9,
        Block = 10,
    }

    public enum Scene
    {
        Unknown,
        Login,
        Lobby,
        Game,
        TestScene
    }

    public enum Sound
    { 
        Bgm,
        Effect,
        MaxCount,
    }

    public enum UIEvent
    { 
        Click,
        Drag,
    }

    public enum MouseEvent
    {
        Press,
        PointerDown,
        PointerUp,
        Click,
        //Wheel,
    }

    public enum KeyboardEvent
    {
        Key_G
    }

    public enum CameraMode
    {
        QuarterView,
    }
}