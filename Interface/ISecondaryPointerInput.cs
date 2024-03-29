using Robotry.Controls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public interface ISecondaryPointerInput
{
    void OnSecondaryPointerDown(SwipeInput input);
    void OnSecondaryPointerDrag(SwipeInput input);
    void OnSecondaryPointerUp(SwipeInput input);
    void OnSecondaryPointerTap(TapInput input);
}
