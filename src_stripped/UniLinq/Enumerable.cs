// Decompiled with JetBrains decompiler
// Type: UniLinq.Enumerable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  public static class Enumerable
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Aggregate<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, TSource, TSource> func)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TAccumulate Aggregate<TSource, TAccumulate>(
      this IEnumerable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> func)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TResult Aggregate<TSource, TAccumulate, TResult>(
      this IEnumerable<TSource> source,
      TAccumulate seed,
      Func<TAccumulate, TSource, TAccumulate> func,
      Func<TAccumulate, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Any<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Average(this IEnumerable<int> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Average(this IEnumerable<long> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Average(this IEnumerable<double> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Average(this IEnumerable<float> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Average(this IEnumerable<Decimal> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TResult? AverageNullable<TElement, TAggregate, TResult>(
      this IEnumerable<TElement?> source,
      Func<TAggregate, TElement, TAggregate> func,
      Func<TAggregate, long, TResult> result)
      where TElement : struct
      where TAggregate : struct
      where TResult : struct
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Average(this IEnumerable<int?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Average(this IEnumerable<long?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Average(this IEnumerable<double?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Average(this IEnumerable<Decimal?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Average(this IEnumerable<float?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Average<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateCastIterator<TResult>(IEnumerable source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Concat<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateConcatIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains<TSource>(
      this IEnumerable<TSource> source,
      TSource value,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Count<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Count<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> DefaultIfEmpty<TSource>(
      this IEnumerable<TSource> source,
      TSource defaultValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateDefaultIfEmptyIterator<TSource>(
      IEnumerable<TSource> source,
      TSource defaultValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Distinct<TSource>(
      this IEnumerable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateDistinctIterator<TSource>(
      IEnumerable<TSource> source,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TSource ElementAt<TSource>(
      this IEnumerable<TSource> source,
      int index,
      Enumerable.Fallback fallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Empty<TResult>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Except<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Except<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateExceptIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TSource First<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate,
      Enumerable.Fallback fallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource First<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource First<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource FirstOrDefault<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<IGrouping<TKey, TSource>> CreateGroupByIterator<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<IGrouping<TKey, TElement>> CreateGroupByIterator<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateGroupByIterator<TSource, TKey, TElement, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      Func<TKey, IEnumerable<TElement>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateGroupByIterator<TSource, TKey, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TKey, IEnumerable<TSource>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateGroupJoinIterator<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, IEnumerable<TInner>, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Intersect<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Intersect<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateIntersectIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, TInner, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateJoinIterator<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, TInner, TResult> resultSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(
      this IEnumerable<TOuter> outer,
      IEnumerable<TInner> inner,
      Func<TOuter, TKey> outerKeySelector,
      Func<TInner, TKey> innerKeySelector,
      Func<TOuter, TInner, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TSource Last<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate,
      Enumerable.Fallback fallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Last<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Last<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource LastOrDefault<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long LongCount<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long LongCount<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Max(this IEnumerable<int> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long Max(this IEnumerable<long> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Max(this IEnumerable<double> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Max(this IEnumerable<float> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Max(this IEnumerable<Decimal> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int? Max(this IEnumerable<int?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long? Max(this IEnumerable<long?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Max(this IEnumerable<double?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Max(this IEnumerable<float?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Max(this IEnumerable<Decimal?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Max<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static U Iterate<T, U>(IEnumerable<T> source, U initValue, Func<T, U, U> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Max<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TResult Max<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Min(this IEnumerable<int> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long Min(this IEnumerable<long> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Min(this IEnumerable<double> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Min(this IEnumerable<float> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Min(this IEnumerable<Decimal> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int? Min(this IEnumerable<int?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long? Min(this IEnumerable<long?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Min(this IEnumerable<double?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Min(this IEnumerable<float?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Min(this IEnumerable<Decimal?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Min<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Min<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TResult Min<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateOfTypeIterator<TResult>(IEnumerable source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<int> Range(int start, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<int> CreateRangeIterator(int start, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateRepeatIterator<TResult>(TResult element, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateReverseIterator<TSource>(IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Select<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateSelectIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> Select<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, int, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateSelectIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, int, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> SelectMany<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TResult>> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateSelectManyIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TResult>> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> SelectMany<TSource, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TResult>> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateSelectManyIterator<TSource, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TResult>> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateSelectManyIterator<TSource, TCollection, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(
      this IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> resultSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TResult> CreateSelectManyIterator<TSource, TCollection, TResult>(
      IEnumerable<TSource> source,
      Func<TSource, int, IEnumerable<TCollection>> collectionSelector,
      Func<TSource, TCollection, TResult> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TSource Single<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate,
      Enumerable.Fallback fallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Single<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource Single<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource SingleOrDefault<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateSkipIterator<TSource>(
      IEnumerable<TSource> source,
      int count)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> SkipWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateSkipWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> SkipWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateSkipWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Sum(this IEnumerable<int> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int? Sum(this IEnumerable<int?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long Sum(this IEnumerable<long> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long? Sum(this IEnumerable<long?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, long?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Sum(this IEnumerable<double> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Sum(this IEnumerable<double?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, double?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Sum(this IEnumerable<float> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Sum(this IEnumerable<float?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, float?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Sum(this IEnumerable<Decimal> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Sum(this IEnumerable<Decimal?> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Decimal? Sum<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, Decimal?> selector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateTakeIterator<TSource>(
      IEnumerable<TSource> source,
      int count)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> TakeWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateTakeWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> TakeWhile<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateTakeWhileIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(
      this IOrderedEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(
      this IEnumerable<TSource> source,
      Func<TSource, TKey> keySelector,
      Func<TSource, TElement> elementSelector,
      IEqualityComparer<TKey> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SequenceEqual<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SequenceEqual<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Union<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Union<TSource>(
      this IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateUnionIterator<TSource>(
      IEnumerable<TSource> first,
      IEnumerable<TSource> second,
      IEqualityComparer<TSource> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Where<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateWhereIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateWhereIterator<TSource>(
      TSource[] source,
      Func<TSource, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<TSource> Where<TSource>(
      this IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateWhereIterator<TSource>(
      IEnumerable<TSource> source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerable<TSource> CreateWhereIterator<TSource>(
      TSource[] source,
      Func<TSource, int, bool> predicate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Exception EmptySequence() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Exception NoMatchingElement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Exception MoreThanOneElement() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Exception MoreThanOneMatchingElement() => throw null;

    private enum Fallback
    {
      Default,
      Throw,
    }
  }
}
