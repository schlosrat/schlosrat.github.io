// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.MoonSharpBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class MoonSharpBinding
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoonSharpBinding() => throw null;

    public class Class<T> where T : class
    {
      private DataType dynValueType;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Class(IValueConverter<T> converter) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Class(IValueConverter<T> converter, DataType dynValueType) => throw null;
    }

    public class Struct<T> where T : struct
    {
      private IValueConverter<T> converter;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Struct(IValueConverter<T> converter) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public T ToValue(DynValue scriptValue) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DynValue FromValue(T? clrValue, Script script) => throw null;
    }

    public class Enum<T>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Enum(IValueConverter<T> converter) => throw null;
    }

    public class Null<T>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Null(IValueConverter<T> converter) => throw null;
    }
  }
}
