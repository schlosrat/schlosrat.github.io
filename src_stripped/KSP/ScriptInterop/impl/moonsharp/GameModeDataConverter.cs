// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.GameModeDataConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Contexts.Game;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (GameModeData), "GameMode", new string[] {"KSP.Contexts.Game.GameModeData"})]
  public class GameModeDataConverter : 
    IStructConverter<GameModeData>,
    IValueConverter<GameModeData>,
    IValueConverter<GameModeData?>
  {
    private TypeInterop typeInterop;
    private GameModeData defaults;
    private MoonSharpBinding.Struct<GameModeData> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModeDataConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(GameModeData? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    GameModeData IValueConverter<GameModeData>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModeData? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(GameModeData clrValue, Script script) => throw null;
  }
}
