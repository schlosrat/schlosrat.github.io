// Decompiled with JetBrains decompiler
// Type: RTG.ConeMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class ConeMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CalcConeBaseExtentPoints(
      Vector3 coneBaseCenter,
      float coneBaseRadius,
      Quaternion coneRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 coneBaseCenter,
      float coneBaseRadius,
      float coneHeight,
      Quaternion coneRotation,
      ConeEpsilon epsilon = default (ConeEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ContainsPoint(
      Vector3 point,
      Vector3 coneBaseCenter,
      float coneBaseRadius,
      float coneHeight,
      Quaternion coneRotation,
      ConeEpsilon epsilon = default (ConeEpsilon))
    {
      throw null;
    }
  }
}
