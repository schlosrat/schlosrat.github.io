// Decompiled with JetBrains decompiler
// Type: Intercept.Visualization.VisualizationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Intercept.Visualization
{
  [CreateAssetMenu(fileName = "DebugVisualizationData", menuName = "ScriptableObjects/VisualizationData")]
  public class VisualizationData : ScriptableObject
  {
    [SerializeField]
    public Mesh XAxesMesh;
    [SerializeField]
    public Mesh YAxesMesh;
    [SerializeField]
    public Mesh ZAxesMesh;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VisualizationData() => throw null;
  }
}
