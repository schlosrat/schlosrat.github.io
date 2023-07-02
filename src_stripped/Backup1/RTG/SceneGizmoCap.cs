// Decompiled with JetBrains decompiler
// Type: RTG.SceneGizmoCap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class SceneGizmoCap
  {
    protected SceneGizmo _sceneGizmo;
    protected GizmoCap3D _cap;

    public int HandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneGizmoCap(SceneGizmo sceneGizmo, int capHandleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoverable(bool isHoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Render(Camera camera) => throw null;
  }
}
