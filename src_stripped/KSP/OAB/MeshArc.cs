// Decompiled with JetBrains decompiler
// Type: KSP.OAB.MeshArc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class MeshArc
  {
    public MeshPoint[] inner;
    public MeshPoint[] outer;
    public FairingCrossSection xSection;
    public float[] hOffsetOuter;
    public float[] hOffsetInner;
    public Vector3 pivot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshArc(FairingCrossSection xSection, MeshPoint[] inner, MeshPoint[] outer) => throw null;
  }
}
