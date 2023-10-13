// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GraphicsUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
