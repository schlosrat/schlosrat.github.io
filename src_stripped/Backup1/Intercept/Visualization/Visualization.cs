// Decompiled with JetBrains decompiler
// Type: Intercept.Visualization.Visualization
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Intercept.Visualization
{
  public class Visualization
  {
    private static readonly string VisualizationDataTag;
    private static VisualizationData _visualizationData;
    private static bool _initializationPending;
    private static bool _initializationFailed;
    private static bool _initialized;
    private static Material _red;
    private static Material _green;
    private static Material _blue;
    private static Action<AsyncOperationHandle<VisualizationData>> completion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool InitializeOnDemand() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Draw3DAxis(Vector3 pos, Quaternion orientation, Vector3 scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Visualization() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Visualization() => throw null;
  }
}
