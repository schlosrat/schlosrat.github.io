// Decompiled with JetBrains decompiler
// Type: TextProButton3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[RequireComponent(typeof (TextMeshPro), typeof (Collider))]
public class TextProButton3D : MonoBehaviour, IMouseEvents
{
  public Color normalColor;
  public Color hoverColor;
  public Color downColor;
  public Callback onPressed;
  public Callback onReleased;
  public Callback onTap;
  private bool lockButton;
  private bool isHover;
  private TextMeshPro text;
  private bool tapping;
  private bool tapped;

  public TextMeshPro Text
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseEnter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseExit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator OnMouseTap() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Lock() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Unlock() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnMouseDrag() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MonoBehaviour GetInstance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TextProButton3D() => throw null;
}
