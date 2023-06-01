// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public class PostProcessingContext
  {
    public PostProcessingProfile profile;
    public Camera camera;
    public MaterialFactory materialFactory;
    public RenderTextureFactory renderTextureFactory;

    public bool interrupted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Interrupt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessingContext Reset() => throw null;

    public bool isGBufferAvailable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isHdr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rect viewport
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessingContext() => throw null;
  }
}
