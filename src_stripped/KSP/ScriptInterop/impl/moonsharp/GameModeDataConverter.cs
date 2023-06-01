// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.GameModeDataConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
