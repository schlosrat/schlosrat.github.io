// Decompiled with JetBrains decompiler
// Type: KSP.OAB.TextMeshProTextOverflowWrapper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.OAB
{
  [RequireComponent(typeof (TextMeshProUGUI))]
  public class TextMeshProTextOverflowWrapper : KerbalMonoBehaviour
  {
    public List<int> TextBoxHeightTiers;
    private TextMeshProUGUI _textTarget;
    private RectTransform _textTransform;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignTextBoxHeight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextMeshProTextOverflowWrapper() => throw null;
  }
}
