// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
  {
    public T model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] internal set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Init(PostProcessingContext pcontext, T pmodel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override PostProcessingModel GetModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PostProcessingComponent() => throw null;
  }
}
