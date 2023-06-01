// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.impl.UniverseCameraViewBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.impl
{
  public abstract class UniverseCameraViewBase
  {
    protected Dictionary<RenderSpaceType, UniverseCameraViewBase.CameraRenderStackEntry> renderStacksByType;
    protected SortedList<int, List<UniverseCameraViewBase.CameraRenderStackEntry>> renderStacksByOrder;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterCameraRenderStack(
      RenderSpaceType type,
      ICameraRenderStack stack,
      int order)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ClearCameraRenderStack(RenderSpaceType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICameraRenderStack GetCameraRenderStack(RenderSpaceType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UniverseCameraViewBase() => throw null;

    protected class CameraRenderStackEntry : 
      IComparable<UniverseCameraViewBase.CameraRenderStackEntry>
    {
      public ICameraRenderStack RenderStack
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public RenderSpaceType RenderType
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int RenderOrder
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CameraRenderStackEntry(ICameraRenderStack stack, RenderSpaceType type, int order) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int CompareTo(
        UniverseCameraViewBase.CameraRenderStackEntry other)
      {
        throw null;
      }
    }
  }
}
