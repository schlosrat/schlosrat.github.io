// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.CustomConvertersCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class CustomConvertersCollection
  {
    private Dictionary<Type, Func<DynValue, object>>[] m_Script2Clr;
    private Dictionary<Type, Func<Script, object, DynValue>> m_Clr2Script;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CustomConvertersCollection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScriptToClrCustomConversion(
      DataType scriptDataType,
      Type clrDataType,
      Func<DynValue, object> converter = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Func<DynValue, object> GetScriptToClrCustomConversion(
      DataType scriptDataType,
      Type clrDataType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetClrToScriptCustomConversion(
      Type clrDataType,
      Func<Script, object, DynValue> converter = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetClrToScriptCustomConversion<T>(Func<Script, T, DynValue> converter = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Func<Script, object, DynValue> GetClrToScriptCustomConversion(Type clrDataType) => throw null;

    [Obsolete("This method is deprecated. Use the overloads accepting functions with a Script argument.")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetClrToScriptCustomConversion(Type clrDataType, Func<object, DynValue> converter = null) => throw null;

    [Obsolete("This method is deprecated. Use the overloads accepting functions with a Script argument.")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetClrToScriptCustomConversion<T>(Func<T, DynValue> converter = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;
  }
}
