// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABPlacedAssembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class OABPlacedAssembly
  {
    [Obsolete("Use Assembly instead")]
    [SerializeField]
    public string assembly;
    public SerializedAssembly Assembly;
    [SerializeField]
    public bool isMainAssembly;
    [SerializeField]
    public Vector3 position;
    [SerializeField]
    public Vector3 boundsSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABPlacedAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABPlacedAssembly(
      Vector3 position,
      Vector3 boundsSize,
      string assembly,
      SerializedAssembly serializedAssembly,
      bool isMainAssembly = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;
  }
}
