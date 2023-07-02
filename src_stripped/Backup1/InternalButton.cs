// Decompiled with JetBrains decompiler
// Type: InternalButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InternalButton : MonoBehaviour
{
  private InternalButton.InternalButtonDelegate onDown;
  private InternalButton.InternalButtonDelegate onUp;
  private InternalButton.InternalButtonDelegate onTap;
  private InternalButton.InternalButtonDelegate onDoubleTap;
  private InternalButton.InternalButtonDelegate onDrag;
  private InternalButton.InternalButtonDelegate onOver;
  private InternalButton.InternalButtonDelegate onExit;
  private bool isMouseDown;
  private bool isTapStarted;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static InternalButton Create(GameObject obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDown(
    InternalButton.InternalButtonDelegate onDownDelegate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnUp(InternalButton.InternalButtonDelegate onUpDelegate) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnTap(
    InternalButton.InternalButtonDelegate onTapDelegate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDoubleTap(
    InternalButton.InternalButtonDelegate onDoubleTapDelegate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnDrag(
    InternalButton.InternalButtonDelegate onDragDelegate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnOver(
    InternalButton.InternalButtonDelegate onOverDelegate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnExit(
    InternalButton.InternalButtonDelegate onExitDelegate)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseTap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseDoubleTap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseDrag() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseOver() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnMouseExit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator TapRoutine(int btn) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public InternalButton() => throw null;

  public delegate void InternalButtonDelegate();
}
