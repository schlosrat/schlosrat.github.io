// Decompiled with JetBrains decompiler
// Type: PrefabLightmapDataObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PrefabLightmapDataObject : ScriptableObject
{
  [SerializeField]
  public Texture2D[] lightmaps;
  [SerializeField]
  public Texture2D[] lightmapsDir;
  [SerializeField]
  public Texture2D[] shadowMasks;
  [SerializeField]
  public SphericalHarmonicsL2 ambientProbe;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PrefabLightmapDataObject() => throw null;
}
