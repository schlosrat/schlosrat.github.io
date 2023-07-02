// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPReplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Replay/Replay Recorder")]
  public class VPReplay : VehicleBehaviour
  {
    [Space(5f)]
    public VPReplay.PlaybackMode playbackMode;
    public VPReplay.EndOfPlayback endOfPlayback;
    public bool autoClearGroundMarks;
    public bool replaySteeringWheelDevice;
    [Space(5f)]
    public VPReplay.OnEnableAction onEnableAction;
    public VPReplayAsset autoLoadReplay;
    [Space(5f)]
    public bool showGui;
    public Vector2 screenPosition;
    public Font font;
    private VPReplay.State m_state;
    private bool m_forceRecordOnEnd;
    private List<VPReplay.Frame> m_recordedData;
    private int m_currentFrame;
    private VPReplay.PlaybackDirection m_playbackDirection;
    private GUIStyle m_smallStyle;
    private GUIStyle m_bigStyle;
    private string m_text;
    private string m_bigText;
    private Vector3 m_velocity;
    private Vector3 m_angularVelocity;
    private int[] m_currentInput;
    private Vector3 m_currentPosition;
    private Quaternion m_currentRotation;
    private VPGroundMarksRenderer[] m_groundMarksRenderers;
    private VPDeviceInput m_deviceInput;
    private VPHeadMotion[] m_headMotions;
    private Gearbox m_gearbox;

    public bool continuityFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public VPReplay.State state
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int currentFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int totalFrames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VPReplay.PlaybackDirection playbackDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Record(VPReplay.RecordMode recordMode = VPReplay.RecordMode.New) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play(VPReplay.PlayMode playMode = VPReplay.PlayMode.FromBegin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pause(VPReplay.PauseMode pauseMode = VPReplay.PauseMode.AtCurrentPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Quit(VPReplay.QuitMode quitMode = VPReplay.QuitMode.AtCurrentPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Jump(int frame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Skip(int frames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Trim(VPReplay.TrimMode trimMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Drop(int dropFrames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPReplayAsset SaveReplayToAsset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadReplayFromAsset(VPReplayAsset replayAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveReplayToAssetFile(string assetFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadReplayFromAssetFile(string assetFileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveReplayToFile(string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadReplayFromFile(string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadReplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int TimeToFrames(float time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float FramesToTime(int frames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string FormatTime(int frames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string FormatFrames(int frames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string FormatTimeAndFrames(int frames) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BeginNewRecord() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ContinueRecord() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ContinueRecordFromReplay(VPReplay.RecordMode recordMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareNextFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BeginPlayback(VPReplay.PlayMode playMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BeginPlaybackInPause(VPReplay.PauseMode pauseMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnterPause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QuitReplay(VPReplay.QuitMode quitMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopReplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessInputHook() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessVisualUpdateHook() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVehicleMode(VPReplay.VehicleMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SaveRigidbodyVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestoreRigidbodyVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RepositionRigidbody(bool allowClearMarks = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveOtherBodiesVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestoreOtherBodiesVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DiscardReplayFrom(int frame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DiscardReplayTo(int frame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecordVehicleData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaybackVehicleData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaybackVehicleVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaybackVisualUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyInputEvent(int[] eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ComputeLinearVelocity(
      Vector3 p0,
      Vector3 p1,
      Quaternion q0,
      Quaternion q1,
      Vector3 localCoM,
      float dt)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ComputeAngularVelocity(Quaternion q0, Quaternion q1, float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPReplay() => throw null;

    public enum PlaybackMode
    {
      InputAndPose,
      InputOnly,
      PoseOnly,
    }

    public enum EndOfPlayback
    {
      Quit,
      Record,
      Pause,
    }

    public enum OnEnableAction
    {
      None,
      PlayLoaded,
      RecordNew,
    }

    [Serializable]
    public struct Frame
    {
      public int[] inputData;
      public Vector3 position;
      public Quaternion rotation;
    }

    public enum State
    {
      Idle,
      Record,
      Playback,
      Paused,
    }

    public enum PlaybackDirection
    {
      Forward,
      Reverse,
    }

    public enum RecordMode
    {
      New,
      Append,
      Restart,
      FromCurrentPos,
      PlayToEndThenAppend,
    }

    public enum PlayMode
    {
      FromBegin,
      FromEnd,
      FromCurrentPos,
    }

    public enum PauseMode
    {
      AtCurrentPos,
      AtBegin,
      AtEnd,
    }

    public enum QuitMode
    {
      AtCurrentPos,
      AtBegin,
      AtEnd,
    }

    public enum TrimMode
    {
      FromBegin,
      ToEnd,
    }

    private enum VehicleMode
    {
      Normal,
      Playback,
      Paused,
    }
  }
}
