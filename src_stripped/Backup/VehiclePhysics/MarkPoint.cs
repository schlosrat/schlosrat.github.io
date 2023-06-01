// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.MarkPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class MarkPoint
  {
    public Vector3 pos;
    public Vector3 normal;
    public Vector4 tangent;
    public Vector3 posl;
    public Vector3 posr;
    public float intensity;
    public int lastIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarkPoint() => throw null;
  }
}
