// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoPlaneDrag3D : GizmoDragSession
  {
    private bool _isSnapEnabled;
    private float _sensitivity;
    protected InputDevicePlaneDragSession3D _planeDragSession;

    public bool IsSnapEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Sensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public override bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool DoBeginSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool DoUpdateSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoEndSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool CanSnap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract Plane CalculateDragPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected GizmoPlaneDrag3D() => throw null;
  }
}
