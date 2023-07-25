// Decompiled with JetBrains decompiler
// Type: KSP.Game.DifficultyOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class DifficultyOption
  {
    public string Id;
    public float MaxValue;
    public float MinValue;
    public float Increment;
    public OptionValueType Type;
    public float Value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DifficultyOption() => throw null;
  }
}
