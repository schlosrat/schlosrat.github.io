// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Serialize.JsonWriterMPSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Networking.MP.Utils;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.MP.Serialize
{
  public class JsonWriterMPSerializer : IMPSerializer
  {
    public const bool DEFAULT_ERROR_AS_WARNING = false;
    private ErrorFlag _errorFlag;
    private Dictionary<string, object> _dict;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogError(string errorString) => throw null;

    public bool ErrorAsWarning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrorAsWarning(bool errorAsWarning) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JsonWriterMPSerializer(bool errorAsWarning = false) => throw null;

    public MPSerializerMode MPSerializerMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrorFlag(string errorString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearErrorFlag() => throw null;

    public bool IsErrorFlagSet
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ErrorString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncBegin(string debugObjectName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncHeader(string headerText) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncBreak() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetJsonStringData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteOutData<T>(string varName, T val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref bool valueRef,
      DefaultValueFactory<bool> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref byte valueRef,
      DefaultValueFactory<byte> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref sbyte valueRef,
      DefaultValueFactory<sbyte> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref short valueRef,
      DefaultValueFactory<short> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref ushort valueRef,
      DefaultValueFactory<ushort> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref int valueRef,
      DefaultValueFactory<int> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref uint valueRef,
      DefaultValueFactory<uint> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref long valueRef,
      DefaultValueFactory<long> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref ulong valueRef,
      DefaultValueFactory<ulong> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref float valueRef,
      DefaultValueFactory<float> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref double valueRef,
      DefaultValueFactory<double> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref char valueRef,
      DefaultValueFactory<char> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSync(
      string varName,
      ref string valueRef,
      DefaultValueFactory<string> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncStringOrNull(
      string varName,
      ref string valueRef,
      DefaultValueFactory<string> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsByte<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsSByte<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsInt16<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsUInt16<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsInt32<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsUInt32<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsInt64<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsUInt64<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncEnumAsString<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncGuid(
      string varName,
      ref Guid valueRef,
      DefaultValueFactory<Guid> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncIGGuid(
      string varName,
      ref IGGuid valueRef,
      DefaultValueFactory<IGGuid> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncVector3(
      string varName,
      ref Vector3 vector3Ref,
      DefaultValueFactory<Vector3> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncColor(
      string varName,
      ref Color colorRef,
      DefaultValueFactory<Color> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncStruct<T>(
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : struct, IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncVarLenUInt64(
      string varName,
      ref ulong valueRef,
      DefaultValueFactory<ulong> defaultValueFactory)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncAtomicArray<T>(
      string varName,
      ref T[] arrayRef,
      DefaultValueFactory<T[]> defaultValueFactory)
      where T : struct
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncObjectArray<T>(
      string varName,
      ref T[] arrayRef,
      DefaultValueFactory<T[]> defaultValueFactory)
      where T : IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncAtomicList<T>(
      string varName,
      ref List<T> listRef,
      DefaultValueFactory<List<T>> defaultValueFactory)
      where T : struct
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncObjectList<T>(
      string varName,
      ref List<T> listRef,
      DefaultValueFactory<List<T>> defaultValueFactory)
      where T : IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncObject<T>(
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : class, IMPSyncable
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MPSyncObjectOrNull<T>(
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : class, IMPSyncable
    {
      throw null;
    }
  }
}
