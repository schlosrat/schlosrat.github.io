// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.MarkPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
