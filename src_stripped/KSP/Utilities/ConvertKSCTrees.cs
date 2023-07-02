// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.ConvertKSCTrees
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  public class ConvertKSCTrees : MonoBehaviour
  {
    [Tooltip("The biome these trees go into.")]
    public BiomeType KSCTreeBiomeType;
    [Tooltip("The parent objects of trees at the KSC.")]
    public List<GameObject> TreeParents;
    [Tooltip("Hide the trees in playmode")]
    public bool HideTreesInPlayMode;
    private const byte KSC_TREES_VEGETATION_SOURCE_ID = 75;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConvertKSCTrees() => throw null;
  }
}
