// Decompiled with JetBrains decompiler
// Type: KerbalRosterKerbalRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class KerbalRosterKerbalRow : MonoBehaviour
{
  public TextMeshProUGUI kerbalName;
  public TextMeshProUGUI simObject;
  public TextMeshProUGUI seat;
  [FormerlySerializedAs("birthDate")]
  public TextMeshProUGUI enrollmentDate;
  public string kerbalKey;
  public IGGuid kerbalId;
  public Action<IGGuid> delete;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Delete() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KerbalRosterKerbalRow() => throw null;
}
