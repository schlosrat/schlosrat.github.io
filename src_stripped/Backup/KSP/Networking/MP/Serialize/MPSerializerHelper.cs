// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Serialize.MPSerializerHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.MP.Serialize
{
  public class MPSerializerHelper
  {
    public const int VAR_LEN_UINT64_CONTINUE_BIT_POSITION = 7;
    public const byte VAR_LEN_UINT64_CONTINUE_FLAG = 128;
    public const byte VAR_LEN_UINT64_DATA_BIT_MASK = 127;
    private static Dictionary<System.Type, MPSerializerHelper.AtomicType> gTypeToAtomicTypeDict;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncGuid(
      IMPSerializer mpSerializer,
      string varName,
      ref Guid objRef,
      DefaultValueFactory<Guid> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncIGGuid(
      IMPSerializer mpSerializer,
      string varName,
      ref IGGuid objRef,
      DefaultValueFactory<IGGuid> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncVector3(
      IMPSerializer mpSerializer,
      string varName,
      ref Vector3 vector3Ref,
      DefaultValueFactory<Vector3> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncColor(
      IMPSerializer mpSerializer,
      string varName,
      ref Color colorRef,
      DefaultValueFactory<Color> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncStruct<T>(
      IMPSerializer mpSerializer,
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : struct, IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MPSerializerHelper.AtomicType TypeToAtomicType(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool MPSyncVarLenUInt64Write(
      IMPSerializer mpSerializer,
      string varName,
      ref ulong valueRef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool MPSyncVarLenUInt64Read(
      IMPSerializer mpSerializer,
      string varName,
      ref ulong valueRef,
      DefaultValueFactory<ulong> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncAtomicArray<T>(
      IMPSerializer mpSerializer,
      string varName,
      ref T[] arrayRef,
      DefaultValueFactory<T[]> defaultValueFactory)
      where T : struct
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncObjectArray<T>(
      IMPSerializer mpSerializer,
      string varName,
      ref T[] arrayRef,
      DefaultValueFactory<T[]> defaultValueFactory)
      where T : IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncAtomicList<T>(
      IMPSerializer mpSerializer,
      string varName,
      ref List<T> listRef,
      DefaultValueFactory<List<T>> defaultValueFactory)
      where T : struct
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncObjectList<T>(
      IMPSerializer mpSerializer,
      string varName,
      ref List<T> listRef,
      DefaultValueFactory<List<T>> defaultValueFactory)
      where T : IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncObject<T>(
      IMPSerializer mpSerializer,
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : class, IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MPSyncObjectOrNull<T>(
      IMPSerializer MPSerializer,
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : class, IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T ConvertStringToType<T>(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertTypeToString<T>(T type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPSerializerHelper() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MPSerializerHelper() => throw null;

    public enum AtomicType
    {
      None,
      Bool,
      Byte,
      SByte,
      Int16,
      UInt16,
      Int32,
      UInt32,
      Int64,
      UInt64,
      Float,
      Double,
      Char,
      String,
      Guid,
    }
  }
}
