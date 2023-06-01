// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.StringConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (string), "String", new string[] {"System.String"})]
  public class StringConverter : IValueConverter<string>
  {
    private TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StringConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(string value, Script script) => throw null;
  }
}
