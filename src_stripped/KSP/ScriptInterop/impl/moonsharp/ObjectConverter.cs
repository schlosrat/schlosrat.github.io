// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ObjectConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (object), null, null)]
  public class ObjectConverter : IValueConverter<object>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Class<object> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(object definition, Script script) => throw null;
  }
}
