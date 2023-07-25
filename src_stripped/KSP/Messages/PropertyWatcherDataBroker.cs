// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatcherDataBroker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class PropertyWatcherDataBroker
  {
    private Dictionary<Type, PropertyWatcherDataBroker.DataContract<double>> _dataContractsDouble;
    private Dictionary<Type, PropertyWatcherDataBroker.DataContract<bool>> _dataContractsBool;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyWatcherDataBroker.DataContract<double> GetContractDouble(Type targetType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyWatcherDataBroker.DataContract<bool> GetContractBool(Type targetType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCurrentDoubleData(Type targetType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetCurrentBoolData(Type targetType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentDoubleData(Type targetType, double value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentBoolData(Type targetType, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterOnDataChangedDouble(Type typeWatched, Action callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterOnDataChangedBool(Type typeWatched, Action callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyWatcherDataBroker() => throw null;

    public class DataContract<T>
    {
      public Action OnDataChanged;
      private T _storedData;

      public T StoredValue
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DataContract() => throw null;
    }
  }
}
