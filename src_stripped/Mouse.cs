// Decompiled with JetBrains decompiler
// Type: Mouse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public static class Mouse
{
  private const string VIRTUAL_MOUSE_NAME = "VirtualMouse";
  public static VirtualMouseConfig Config;
  private static Mouse.ControlScheme _controlScheme;
  private static List<GraphicRaycaster> _uiRayCasters;
  private static PointerEventData _pointerEventData;
  private static List<RaycastResult> _graphicRaycastResults;
  private static Mouse _virtualMouse;
  private static GameInput.CursorActions _input;

  public static Mouse.MouseButton Left
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static Mouse.MouseButton Right
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static Mouse.MouseButton Middle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static Mouse.ControlScheme CurrentScheme
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static Vector2 Position
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private static Vector2 systemPosition
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  private static Vector2 virtualPosition
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public static Vector2 SystemDelta
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static Vector2 SystemScroll
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool IsSystemMouseMoving
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool IsProcessingEvents
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static bool IsGamepadEnabled
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public static List<RaycastResult> GraphicRaycastResults
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool IsOverUI
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void AddCanvasInteractableToCursor(GraphicRaycaster graphicRaycaster) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void RemoveCanvasInteractableToCursor(GraphicRaycaster graphicRaycaster) => throw null;

  private static GameInstance Game
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private static Mouse SystemMouse
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private static Mouse VirtualMouse
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetActive(bool isActive) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void EnableVirtualCursor(bool isEnabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetGamePadInput(bool shouldEnable) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetVirtualCursor(Sprite sprite) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetSystemCursor(Sprite sprite, CursorMode mode = CursorMode.Auto) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Initialize(VirtualMouseConfig config, GameInput input) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static Mouse() => throw null;

  public enum ControlScheme
  {
    None,
    Mouse,
    Gamepad,
  }

  public abstract class MouseButton
  {
    protected InputAction _pressMouse;
    protected InputAction _doubleTapMouse;
    protected InputAction _pressGamepad;
    protected InputAction _doubleTapGamepad;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool WasPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool WasReleasedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool IsPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool GetDoubleClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected MouseButton() => throw null;
  }

  public class LeftButton : Mouse.MouseButton
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LeftButton(GameInput.CursorActions map) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasReleasedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool GetDoubleClick() => throw null;
  }

  public class RightButton : Mouse.MouseButton
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RightButton(GameInput.CursorActions map) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasReleasedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool GetDoubleClick() => throw null;
  }

  public class MiddleButton : Mouse.MouseButton
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MiddleButton(GameInput.CursorActions map) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool WasReleasedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool GetDoubleClick() => throw null;
  }
}
