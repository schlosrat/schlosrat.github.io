// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.PropertyDerived`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes.Generic;
using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class PropertyDerived<TOutput, TInput> : IProperty<TOutput>, IProperty
  {
    private EventHandlerProxy<TOutput> onChangedProxy;
    private static string[] cachedEnumNames;
    private static int[] cachedEnumIndices;
    private readonly Func<TInput> valueGetter;
    private PropertyDerived<TOutput, TInput>.EvaluationCallback evaluator;
    private TOutput derivedValue;

    public event Action<TOutput> OnChangedValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<object> OnChangedObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Type StoredType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TOutput GetValue() => throw null;

    public string[] EnumNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int[] EnumIndices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PropertyDerived() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnumValues(string[] newEnumNames, int[] newEnumIndices = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyDerived(
      PropertyDerived<TOutput, TInput>.EvaluationCallback evaluator)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyDerived(
      Func<TInput> getter,
      PropertyDerived<TOutput, TInput>.EvaluationCallback evaluator)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDerived() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDerived(TInput source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void InvokeValueChanged(TOutput newValue) => throw null;

    public delegate TOutput EvaluationCallback(TInput input);
  }
}
