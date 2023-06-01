// Decompiled with JetBrains decompiler
// Type: KSP.AsyncSearchSortFilter.AsyncSearchSortFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace KSP.AsyncSearchSortFilter
{
  public class AsyncSearchSortFilter : IUpdate
  {
    private static KSP.AsyncSearchSortFilter.AsyncSearchSortFilter _instance;
    private bool _listeningForUpdates;
    private List<AbstractOperationData> _operationQueue;

    public static KSP.AsyncSearchSortFilter.AsyncSearchSortFilter Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StartSearch<T>(
      KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.MatchFunctionDelegate<T> matchFunction,
      List<T> inData,
      KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.AsyncSSFCallback<T> asyncSSFCallback,
      string searchQuery)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StartSortCopy<T>(
      Comparison<T> comparisonFunction,
      List<T> inData,
      KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.AsyncSSFCallback<T> asyncSSFCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StartSort<T>(
      Comparison<T> comparisonFunction,
      List<T> inData,
      KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.AsyncSSFCallback<T> asyncSSFCallback,
      Mutex mutexDataLock)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void EnqueueNewOperation(AbstractOperationData sData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterForUpdates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterForUpdates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsyncSearchSortFilter() => throw null;

    public delegate bool MatchFunctionDelegate<T>(T element, string query);

    public delegate void AsyncSSFCallback<T>(List<T> returnData);
  }
}
