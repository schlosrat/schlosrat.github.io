// Decompiled with JetBrains decompiler
// Type: EngineVFXTestingTool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP;
using KSP.Messages;
using KSP.OAB;
using KSP.VFX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EngineVFXTestingTool : MonoBehaviour
{
  private static Dictionary<MetaAssemblySizeFilterType, float> SceneViewSizeByPartSize;
  private MessageCenter DebugMessageCenter;
  public List<EngineVFXTestingTool.EngineControlData> Engines;
  public static Vector3 RotationSpeed;
  private List<string> fuelTypeNameList;
  public GameObject[] AssetsToToggleWithEVATesting;
  private fx_fly_camera _cameraController;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CollectAllThrottleVFXManagers(
    ref SortedDictionary<string, List<EngineVFXTestingTool.EngineControlData>> engineGroupDictionary)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CollectAllRCSVFXManagers(
    ref SortedDictionary<string, List<EngineVFXTestingTool.EngineControlData>> engineGroupDictionary)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CollectAllJetpackVFXManagers(
    ref SortedDictionary<string, List<EngineVFXTestingTool.EngineControlData>> engineGroupDictionary)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void UpdateAudioValuesOnEngine(EngineVFXTestingTool.EngineControlData curECD) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartOrStopVFXOnEngine(
    EngineVFXTestingTool.EngineControlData ECD,
    bool isEngineActive)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FlameoutVFXOnEngine(EngineVFXTestingTool.EngineControlData ECD, bool doFlameout) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SwapModesOnEngine(
    EngineVFXTestingTool.EngineControlData ECD,
    int fromIndex,
    int toIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void StopAudioOnEngine(EngineVFXTestingTool.EngineControlData ECD) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void StartAudioOnEngine(EngineVFXTestingTool.EngineControlData ECD) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void TriggerBoom(EngineVFXTestingTool.EngineControlData ECD) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EngineVFXTestingTool.EngineControlData FindEngineControlByName(string name) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int SortEngineControlData(
    EngineVFXTestingTool.EngineControlData ECD1,
    EngineVFXTestingTool.EngineControlData ECD2)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EngineVFXTestingTool() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static EngineVFXTestingTool() => throw null;

  [Serializable]
  public class EngineControlData
  {
    public string Name;
    public bool DebugMode;
    [HideInInspector]
    public ThrottleVFXManager TVM;
    [HideInInspector]
    public RCSVFXManager RVM;
    [HideInInspector]
    public JetpackVFXManager JVM;
    public List<KSPPartAudioBase> PartAudioBaseList;
    public CorePartData PartData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineControlData(ThrottleVFXManager _tvm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineControlData(RCSVFXManager _rvm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EngineControlData(JetpackVFXManager _jvm) => throw null;
  }
}
