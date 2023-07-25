// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartPlacementVFX
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class PartPlacementVFX
  {
    private const string PREFAB_NAME = "fx_spark_one_shot";
    private GameObject _sparkPrefab;
    public bool VFXInitialized;
    private ParticleSystem _particleParent;
    private ParticleSystem[] _particles;
    private GameObject _vfxInstance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Terminate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadAttachVFX(
      IObjectAssemblyPart partBeingAttached,
      IObjectAssemblyPart partToAttachTo,
      IObjectAssemblyPartNode nodeBeingAttached = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlayFX(
      IObjectAssemblyPart partBeingAttached,
      IObjectAssemblyPartNode nodeBeingAttached = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartPlacementVFX() => throw null;
  }
}
