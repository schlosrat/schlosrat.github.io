// Decompiled with JetBrains decompiler
// Type: KSP.Game.AgencyUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public static class AgencyUtils
  {
    public const int AGENCY_ID_NONE = 0;
    public const string DEFAULT_AGENCY_NAME = "Kerbal Space Agency";
    public static readonly Color DEFAULT_AGENCY_COLOR_BASE;
    public static readonly Color DEFAULT_AGENCY_COLOR_ACCENT;
    public const string COLOR_ACCENT_NAME = "_PaintA";
    public const string COLOR_BASE_NAME = "_PaintB";
    public static int COLOR_ACCENT_ID;
    public static int COLOR_BASE_ID;
    public static string DEFAULT_FLAG_SPRITE_LOCATION;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetBestInitialStartingColors(
      out Color startingColorBaseOut,
      out Color startingColorAccentOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AgencyUtils() => throw null;

    [Serializable]
    public class TeamColorSet
    {
      public Color Base;
      public Color Accent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TeamColorSet() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TeamColorSet(Color overrideBase, Color overrideAccent) => throw null;
    }
  }
}
