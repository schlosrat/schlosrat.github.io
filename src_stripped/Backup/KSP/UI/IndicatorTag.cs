// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class IndicatorTag : KerbalMonoBehaviour
  {
    [SerializeField]
    protected string tagName;
    protected RectTransform rectTransform;
    protected bool _validTag;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterTag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterTag(string _tagName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorTag() => throw null;
  }
}
