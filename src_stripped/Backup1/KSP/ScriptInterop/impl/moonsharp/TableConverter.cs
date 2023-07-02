// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.TableConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
