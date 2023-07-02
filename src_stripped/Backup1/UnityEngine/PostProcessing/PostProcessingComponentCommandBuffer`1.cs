// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
  public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract CameraEvent GetCameraEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract string GetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void PopulateCommandBuffer(CommandBuffer cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PostProcessingComponentCommandBuffer() => throw null;
  }
}
