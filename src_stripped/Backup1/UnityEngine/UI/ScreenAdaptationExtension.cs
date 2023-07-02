// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ScreenAdaptationExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  public static class ScreenAdaptationExtension
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Approximately(this float a, float b, float tolerance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RectTransform GetRectTransform<T>(this T element) where T : Behaviour => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 Center(this RectTransform rectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WorldToScreen(this Vector3[] points, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RestrictInParentRectBy(
      this RectTransform baseRectTransform,
      RectTransform targetRectTransform)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 LocalPositionAt(this Transform baseTransform, Transform targetTransform) => throw null;
  }
}
