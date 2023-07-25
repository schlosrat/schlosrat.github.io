// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Biomes.Node
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Biomes
{
  [Serializable]
  public class Node
  {
    public bool Selected;
    public Vector3 Position;
    public bool OverrideWidth;
    public float CustomWidth;
    public bool Active;
    public bool DisableEdge;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Node() => throw null;
  }
}
