// Decompiled with JetBrains decompiler
// Type: PartToolsLibrary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
