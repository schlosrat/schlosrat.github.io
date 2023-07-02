// Decompiled with JetBrains decompiler
// Type: ReleaseRuntimeMeshOnDestroy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class ReleaseRuntimeMeshOnDestroy : MonoBehaviour
{
  private Mesh _meshToRelease;
  private RuntimeMeshTracker _meshTracker;
  private int trackedInstanceID;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetMeshToTrack(Mesh meshToRelease, RuntimeMeshTracker meshTracker = null) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void TrackMesh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ReleaseRuntimeMeshOnDestroy() => throw null;
}
