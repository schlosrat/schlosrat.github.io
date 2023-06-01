// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.IEnumerableConverters`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (IEnumerable<>), "Enumerable", new string[] {"IEnumerable", "System.Collections.Generic.IEnumerable"})]
  public class IEnumerableConverters<T> : IValueConverter<IEnumerable<T>>
  {
    private TypeInterop typeInterop;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerableConverters(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<T> ToValue(DynValue from) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(IEnumerable<T> definition, Script script) => throw null;
  }
}
