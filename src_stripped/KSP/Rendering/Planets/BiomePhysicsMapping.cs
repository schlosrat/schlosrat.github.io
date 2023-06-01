// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.BiomePhysicsMapping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [CreateAssetMenu(fileName = "Biome", menuName = "ScriptableObjects/BiomePhysicsMapping")]
  public class BiomePhysicsMapping : ScriptableObject
  {
    [SerializeField]
    public List<BiomePhysicsPair> BiomeTypeToPhysicsPairs;
    private Dictionary<PQSData.KSP2BiomeType, PhysicMaterial> _typetoMaterial;
    private Dictionary<string, PQSData.KSP2BiomeType> _materialToType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomePhysicsMapping() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PhysicMaterial GetMaterial(PQSData.KSP2BiomeType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.KSP2BiomeType GetType(PhysicMaterial type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Validate() => throw null;
  }
}
