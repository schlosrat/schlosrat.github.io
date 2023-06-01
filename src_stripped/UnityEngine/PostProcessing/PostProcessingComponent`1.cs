// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponent`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
