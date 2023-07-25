// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.FloatCurveConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (FloatCurve), "FloatCurve")]
  public class FloatCurveConverter : IValueConverter<FloatCurve>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Class<FloatCurve> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatCurveConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatCurve ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(FloatCurve clrValue, Script script) => throw null;
  }
}
