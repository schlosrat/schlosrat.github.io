// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.ColorBlockPreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [CreateAssetMenu(fileName = "ColorBlockPreset", menuName = "UI Extended/ColorBlockPreset", order = 100)]
  [Serializable]
  public class ColorBlockPreset : ScriptableObject
  {
    public ColorBlock colors;

    public static ColorBlock DefaultColors
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static ColorBlock DefaultColorsOn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static ColorBlock DefaultColorsOff
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorBlockPreset() => throw null;
  }
}
