// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtLight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtLight")]
  [RequireComponent(typeof (Light))]
  [ExecuteInEditMode]
  [AddComponentMenu("Space Graphics Toolkit/SGT Light")]
  public class SgtLight : SgtLinkedBehaviour<SgtLight>
  {
    public bool TreatAsPoint;
    [NonSerialized]
    private Light cachedLight;
    [NonSerialized]
    private bool cachedLightSet;
    private static List<SgtLight.LightProperties> cachedLightProperties;
    private static List<string> cachedLightKeywords;
    private static List<SgtLight> tempLights;

    public Light CachedLight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SgtLight> Find(bool lit, int mask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FilterOut(Vector3 center) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Calculate(
      SgtLight light,
      Vector3 center,
      Transform directionTransform,
      Transform positionTransform,
      ref Vector3 position,
      ref Vector3 direction,
      ref Color color)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Write(
      bool lit,
      Vector3 center,
      Transform directionTransform,
      Transform positionTransform,
      float scatterStrength,
      int maxLights)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MicrosplatWrite(
      Vector3 center,
      Transform directionTransform,
      Transform positionTransform,
      ref Vector3 position,
      ref Vector3 direction,
      ref Color color)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SgtLight.LightProperties GetLightProperties(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetLightKeyword(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SgtLight() => throw null;

    private class LightProperties
    {
      public int Direction;
      public int Position;
      public int Color;
      public int Scatter;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LightProperties() => throw null;
    }
  }
}
