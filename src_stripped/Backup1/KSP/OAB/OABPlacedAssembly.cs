// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABPlacedAssembly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
