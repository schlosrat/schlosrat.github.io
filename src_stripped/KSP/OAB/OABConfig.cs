// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public struct OABConfig
  {
    public OABVariant Variant;
    public OABEnvironmentType EnvironmentType;
    public OABConstructionType ConstructionType;
    public string CelestialBodyDependencyName;
    public SerializedAssembly Assembly;
    public IGGuid EditTargetSimObject;
    public IGGuid LaunchpadSimObject;
    public bool HasExitLocation;
    public Vector3d ExitOffsetLocalPosition;
    public Quaternion ExitOffsetLocalRotation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABConfig(
      OABVariant variant,
      OABEnvironmentType environmentType,
      OABConstructionType constructionType,
      string celestialBodyDependencyName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EditExistingAssembly(SerializedAssembly assembly, IGGuid editTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetExitLocation(IGGuid launchpad, Vector3d pos, Quaternion rot) => throw null;
  }
}
