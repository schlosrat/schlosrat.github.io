// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PartPropertiesConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PartProperties), "Part", new string[] {"PartProperties", "KSP.Sim.Definitions.PartProperties"})]
  public class PartPropertiesConverter : 
    IStructConverter<PartProperties>,
    IValueConverter<PartProperties>,
    IValueConverter<PartProperties?>
  {
    public const string MODULE_TYPE_KEY = "moduleType";
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PartProperties> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartPropertiesConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PartProperties IValueConverter<PartProperties>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartProperties? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartProperties? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PartProperties properties, Script script) => throw null;
  }
}
