// Decompiled with JetBrains decompiler
// Type: PrefabLightmapDataObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
