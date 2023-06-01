// Decompiled with JetBrains decompiler
// Type: AutoHideOnNoInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (RectTransform))]
public class AutoHideOnNoInput : MonoBehaviour
{
  public float secondsBeforeHide;
  public float hideDuration;
  public float showDuration;
  public Vector2 hideOffset;
  private float timer;
  private bool wasHide;
  private RectTransform rect;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool CheckUIChange() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AutoHideOnNoInput() => throw null;
}
