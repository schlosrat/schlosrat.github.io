// Decompiled with JetBrains decompiler
// Type: CreditsMultiTextHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CreditsMultiTextHeader : MonoBehaviour
{
  public CreditsMultiTextHeader.TextHeader[] textTrfs;
  private int currentText;
  public Transform startAnchor;
  public Transform centerAnchor;
  public Transform endAnchor;
  public float transitionDuration;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetText(int idx, float duration) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void NextText() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator shiftText(
    CreditsMultiTextHeader.TextHeader textTrf,
    Transform tgtAnchor,
    float duration)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CreditsMultiTextHeader() => throw null;

  [Serializable]
  public class TextHeader
  {
    public Transform headerRef;
    public Transform currentAnchor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextHeader() => throw null;
  }
}
