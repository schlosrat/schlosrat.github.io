// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.CustomConvertersCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
