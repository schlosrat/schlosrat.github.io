// Decompiled with JetBrains decompiler
// Type: Intercept.Visualization.VisualizationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
