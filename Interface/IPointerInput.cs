using Robotry.Controls;
using UnityEngine;
using UnityEngine.InputSystem;

public interface IPointerInput
{
    public void OnPointerDown(Vector2 vector2);
    public void OnPointerDrag(SwipeInput input);
    public void OnPointerUp(SwipeInput input);
    public void OnPointerTap(TapInput input);
    public void OnPointerDoubleTap(TapInput input);
    public void OnPointerLongTap(TapInput input);

}
