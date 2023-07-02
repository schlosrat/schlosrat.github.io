// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABENVSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class OABENVSpawner : MonoBehaviour
  {
    public List<ObjectAssemblyEnvironment> environments;
    private List<OABENVSpawner.EnvEntry> spawnedEnvironments;
    private OABEnvironmentType lastSetType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetEntry(OABEnvironmentType type, out OABENVSpawner.EnvEntry envEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyEnvironment CurrentEnvironment() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOthersInactive(OABEnvironmentType activeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetActiveEnvironment(OABEnvironmentType desiredEnvType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABENVSpawner() => throw null;

    private class EnvEntry
    {
      public OABEnvironmentType type;
      public ObjectAssemblyEnvironment env;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EnvEntry(OABEnvironmentType type, ObjectAssemblyEnvironment env) => throw null;
    }
  }
}
