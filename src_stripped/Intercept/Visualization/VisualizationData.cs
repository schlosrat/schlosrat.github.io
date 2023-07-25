// Decompiled with JetBrains decompiler
// Type: Intercept.Visualization.VisualizationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
