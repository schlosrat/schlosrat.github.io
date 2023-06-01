// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GraphicsUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public static class GraphicsUtils
  {
    private static Texture2D s_WhiteTexture;
    private static Mesh s_Quad;

    public static bool isLinearColorSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool supportsDX11
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Texture2D whiteTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Mesh quad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Blit(Material material, int pass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearAndBlit(
      Texture source,
      RenderTexture destination,
      Material material,
      int pass,
      bool clearColor = true,
      bool clearDepth = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Destroy(Object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Dispose() => throw null;
  }
}
