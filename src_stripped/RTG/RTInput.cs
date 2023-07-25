// Decompiled with JetBrains decompiler
// Type: RTG.RTInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RTG
{
  public static class RTInput
  {
    private static Key[] _keyMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static RTInput() => throw null;

    public static Vector3 MousePosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool IsMousePresent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int TouchCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasLeftMouseButtonPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasRightMouseButtonPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasMiddleMouseButtonPressedThisFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasMouseButtonPressedThisFrame(int mouseButton) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasMouseButtonReleasedThisFrame(int mouseButton) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsLeftMouseButtonPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsRightMouseButtonPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsMiddleMouseButtonPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsMouseButtonPressed(int mouseButton) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasMouseMoved() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float MouseAxisX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float MouseAxisY() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float MouseScroll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WasKeyPressedThisFrame(KeyCode keyCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsKeyPressed(KeyCode keyCode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 TouchDelta(int touchIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector2 TouchPosition(int touchIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TouchBegan(int touchIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TouchEndedOrCanceled(int touchIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TouchMoved(int touchIndex) => throw null;
  }
}
