// Decompiled with JetBrains decompiler
// Type: PartToolsLibrary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("KSP/Part Tools Library")]
public class PartToolsLibrary : MonoBehaviour
{
  public List<PartTools> partPrefabs;
  public string loaderLevelName;
  public bool forceTextureFormat;
  public PartTools.TextureFormat textureFormat;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PartToolsLibrary() => throw null;
}
