// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.TableConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (Dictionary<string, object>), "Table<string,object>", new string[] {"Dictionary<string,object>", "System.Collections.Generic.Dictionary<string,object>"})]
  public class TableConverter : IValueConverter<Dictionary<string, object>>
  {
    private TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TableConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Dictionary<string, object> ToValue(DynValue from) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(Dictionary<string, object> definition, Script script) => throw null;
  }
}
