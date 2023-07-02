// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.QuaternionDConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (QuaternionD), "Quatd", new string[] {"QuaternionD"})]
  public class QuaternionDConverter : 
    IStructConverter<QuaternionD>,
    IValueConverter<QuaternionD>,
    IValueConverter<QuaternionD?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<QuaternionD> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionDConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    QuaternionD IValueConverter<QuaternionD>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(QuaternionD? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(QuaternionD clrValue, Script script) => throw null;
  }
}
