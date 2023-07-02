// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Serialize.IMPSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace KSP.Networking.MP.Serialize
{
  public interface IMPSerializer
  {
    MPSerializerMode MPSerializerMode { get; }

    void SetErrorFlag(string errorString);

    void ClearErrorFlag();

    bool IsErrorFlagSet { get; }

    string ErrorString { get; }

    void MPSyncBegin(string debugObjectName);

    void MPSyncEnd();

    void MPSyncHeader(string headerText);

    void MPSyncBreak();

    void MPSync(string varName, ref bool valueRef, DefaultValueFactory<bool> defaultValueFactory);

    void MPSync(string varName, ref byte valueRef, DefaultValueFactory<byte> defaultValueFactory);

    void MPSync(string varName, ref sbyte valueRef, DefaultValueFactory<sbyte> defaultValueFactory);

    void MPSync(string varName, ref short valueRef, DefaultValueFactory<short> defaultValueFactory);

    void MPSync(
      string varName,
      ref ushort valueRef,
      DefaultValueFactory<ushort> defaultValueFactory);

    void MPSync(string varName, ref int valueRef, DefaultValueFactory<int> defaultValueFactory);

    void MPSync(string varName, ref uint valueRef, DefaultValueFactory<uint> defaultValueFactory);

    void MPSync(string varName, ref long valueRef, DefaultValueFactory<long> defaultValueFactory);

    void MPSync(string varName, ref ulong valueRef, DefaultValueFactory<ulong> defaultValueFactory);

    void MPSync(string varName, ref float valueRef, DefaultValueFactory<float> defaultValueFactory);

    void MPSync(
      string varName,
      ref double valueRef,
      DefaultValueFactory<double> defaultValueFactory);

    void MPSync(string varName, ref char valueRef, DefaultValueFactory<char> defaultValueFactory);

    void MPSync(
      string varName,
      ref string valueRef,
      DefaultValueFactory<string> defaultValueFactory);

    void MPSyncStringOrNull(
      string varName,
      ref string valueRef,
      DefaultValueFactory<string> defaultValueFactory);

    void MPSyncEnumAsByte<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsSByte<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsInt16<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsUInt16<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsInt32<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsUInt32<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsInt64<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsUInt64<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncEnumAsString<T>(
      string varName,
      ref T valueRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : Enum;

    void MPSyncGuid(
      string varName,
      ref Guid valueRef,
      DefaultValueFactory<Guid> defaultValueFactory);

    void MPSyncIGGuid(
      string varName,
      ref IGGuid valueRef,
      DefaultValueFactory<IGGuid> defaultValueFactory);

    void MPSyncVector3(
      string varName,
      ref Vector3 vector3Ref,
      DefaultValueFactory<Vector3> defaultValueFactory);

    void MPSyncColor(
      string varName,
      ref Color colorRef,
      DefaultValueFactory<Color> defaultValueFactory);

    void MPSyncStruct<T>(string varName, ref T objRef, DefaultValueFactory<T> defaultValueFactory) where T : struct, IMPSyncable;

    void MPSyncVarLenUInt64(
      string varName,
      ref ulong valueRef,
      DefaultValueFactory<ulong> defaultValueFactory);

    void MPSyncAtomicArray<T>(
      string varName,
      ref T[] arrayRef,
      DefaultValueFactory<T[]> defaultValueFactory)
      where T : struct;

    void MPSyncObjectArray<T>(
      string varName,
      ref T[] arrayRef,
      DefaultValueFactory<T[]> defaultValueFactory)
      where T : IMPSyncable;

    void MPSyncAtomicList<T>(
      string varName,
      ref List<T> listRef,
      DefaultValueFactory<List<T>> defaultValueFactory)
      where T : struct;

    void MPSyncObjectList<T>(
      string varName,
      ref List<T> listRef,
      DefaultValueFactory<List<T>> defaultValueFactory)
      where T : IMPSyncable;

    void MPSyncObject<T>(string varName, ref T objRef, DefaultValueFactory<T> defaultValueFactory) where T : class, IMPSyncable;

    void MPSyncObjectOrNull<T>(
      string varName,
      ref T objRef,
      DefaultValueFactory<T> defaultValueFactory)
      where T : class, IMPSyncable;
  }
}
