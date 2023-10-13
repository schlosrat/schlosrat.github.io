// Decompiled with JetBrains decompiler
// Type: AutoHideOnNoInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
