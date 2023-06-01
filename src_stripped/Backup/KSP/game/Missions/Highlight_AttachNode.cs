// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Highlight_AttachNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  public class Highlight_AttachNode : Highlight
  {
    [Header("Set values")]
    [SerializeField]
    private PartSizeHighlightScale[] scaleFactor;
    private Vector3 newScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(Highlight_Data data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScale(MetaAssemblySizeFilterType sizeFilterType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Highlight_AttachNode() => throw null;
  }
}
