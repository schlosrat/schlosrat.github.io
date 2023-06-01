// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineFollowAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

namespace EdyCommonTools
{
  public class SplineFollowAsset : PlayableAsset
  {
    public ExposedReference<Spline> spline;
    public bool followRotation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SplineFollowAsset() => throw null;
  }
}
