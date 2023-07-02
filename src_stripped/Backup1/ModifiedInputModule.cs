// Decompiled with JetBrains decompiler
// Type: ModifiedInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ModifiedInputModule : PointerInputModule
{
  public static ModifiedInputModule current;
  private Vector2 m_VirtualMousePosition;
  private readonly PointerInputModule.MouseState m_MouseState;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TrySetAsCurrent() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static PointerEventData GetPointerEventData(int pointerId = -1) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RectTransform GetUIObjectUnderCursor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector2 GetCursorPos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RectTransform GetUIObjectUnderCursorEx(out Vector3 hitPos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RectTransform GetClickedUIObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameObject GetGameObjectUnderCursor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void ActivateModule() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void DeactivateModule() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void Process() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void ProcessMouseEvent() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void ProcessMouseEvent(int id) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected bool SendUpdateEventToSelectedObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void ProcessMousePress(
    PointerInputModule.MouseButtonEventData data,
    Mouse.MouseButton button)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override PointerInputModule.MouseState GetMousePointerEventData(int id) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ModifiedInputModule() => throw null;
}
