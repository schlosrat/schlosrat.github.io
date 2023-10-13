// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.MarkPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
