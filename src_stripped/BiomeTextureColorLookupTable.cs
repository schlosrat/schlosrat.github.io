// Decompiled with JetBrains decompiler
// Type: BiomeTextureColorLookupTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "BiomeTextureColorLookupTable", menuName = "ScriptableObjects/BiomeTextureColorLookupTable")]
[Serializable]
public class BiomeTextureColorLookupTable : ScriptableObject
{
  public List<BiomeLookupEditorPair> BiomeLookupPairs;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string[] GetAllNames() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Color[] GetAllColors() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Color GetColor(int iIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BiomeTextureColorLookupTable() => throw null;
}
