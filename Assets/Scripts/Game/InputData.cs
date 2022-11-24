using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

[Serializable]
public class InputData
{
    [SerializeField] public string ControllSheme = "Keyboard";
    [SerializeField] public Vector2 CursorPosition = Vector2.zero;
    [SerializeField] public Vector3 CursorWorldPosition = Vector3.zero;
    [SerializeField] public Vector2 MoveDir = Vector2.zero;
    [SerializeField] public Vector2 LookDir = Vector2.zero;
    [SerializeField] public bool Interact = false;
    [SerializeField] public bool Cancel = false;
    [SerializeField] public bool PlaceObject = false;
    [SerializeField] public bool OpenBuildingsMenu = false;
    [SerializeField] public bool OpenMinionsMenu = false;
    [SerializeField] public bool BaseSkill = false;
    [SerializeField] public bool BaseSkillCharge = false;
    [SerializeField] public bool FirstSkill = false;
    [SerializeField] public bool SecondSkill = false;
    [SerializeField] public bool FirstItem = false;
    [SerializeField] public bool SecondItem = false;
    [SerializeField] public bool ThirdItem = false;
    [SerializeField] public bool FourthItem = false;
}

