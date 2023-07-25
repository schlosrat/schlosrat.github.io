// Decompiled with JetBrains decompiler
// Type: KSP.OAB.MeshArc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
