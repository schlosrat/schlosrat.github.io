// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.ModelPosInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace KSP.Networking.MP.Utils
{
  public struct ModelPosInfo
  {
    public const bool DEFAULT_GOT_POSITION_AND_ROTATION = false;
    public const string DEFAULT_PARENT_TRANSFORM_FRAME_GLOBAL_ID_STRING = "";
    public const TransformFrameType DEFAULT_PARENT_TRANSFORM_FRAME_TYPE = TransformFrameType.None;
    public const double DEFAULT_POSITION_X = 0.0;
    public const double DEFAULT_POSITION_Y = 0.0;
    public const double DEFAULT_POSITION_Z = 0.0;
    public const double DEFAULT_ROTATION_X = 0.0;
    public const double DEFAULT_ROTATION_Y = 0.0;
    public const double DEFAULT_ROTATION_Z = 0.0;
    public const double DEFAULT_ROTATION_W = 0.0;
    public const bool DEFAULT_GOT_VELOCITY_AND_ANGULAR_VELOCITY = false;
    public const double DEFAULT_VELOCITY_X = 0.0;
    public const double DEFAULT_VELOCITY_Y = 0.0;
    public const double DEFAULT_VELOCITY_Z = 0.0;
    public const double DEFAULT_ANGULAR_VELOCITY_X = 0.0;
    public const double DEFAULT_ANGULAR_VELOCITY_Y = 0.0;
    public const double DEFAULT_ANGULAR_VELOCITY_Z = 0.0;
    public const double DEFAULT_OFFSET_POSITION_X = 0.0;
    public const double DEFAULT_OFFSET_POSITION_Y = 0.0;
    public const double DEFAULT_OFFSET_POSITION_Z = 0.0;
    public bool GotPositionAndRotation;
    public string ParentTransformFrameGlobalIdString;
    public TransformFrameType ParentTransformFrameType;
    public double PositionX;
    public double PositionY;
    public double PositionZ;
    public double RotationX;
    public double RotationY;
    public double RotationZ;
    public double RotationW;
    public bool GotVelocityAndAngularVelocity;
    public double VelocityX;
    public double VelocityY;
    public double VelocityZ;
    public double AngularVelocityX;
    public double AngularVelocityY;
    public double AngularVelocityZ;
    public double OffsetPositionX;
    public double OffsetPositionY;
    public double OffsetPositionZ;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(ModelPosInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(ModelPosInfo src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion GetRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotation(Quaternion quat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetOffsetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOffsetPosition(Vector3 offsetPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddStringToStringBuilder(
      StringBuilder stringBuilder,
      string varName,
      string varValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ExportLocationString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ImportLocationString(string locationString) => throw null;

    public static class TOKEN
    {
      public const char SEPARATOR_CHAR = '&';
      public const string SEPARATOR_STRING = "&";
      public const char EQUALS_CHAR = '=';
      public const string EQUALS_STRING = "=";
      public const string PARENT_TRANSFORM_FRAME_GLOBAL_ID_STRING = "frame";
      public const string PARENT_TRANSFORM_FRAME_TYPE = "type";
      public const string POSITION_X = "px";
      public const string POSITION_Y = "py";
      public const string POSITION_Z = "pz";
      public const string ROTATION_X = "rx";
      public const string ROTATION_Y = "ry";
      public const string ROTATION_Z = "rz";
      public const string ROTATION_W = "rw";
      public const string VELOCITY_X = "vx";
      public const string VELOCITY_Y = "vy";
      public const string VELOCITY_Z = "vz";
      public const string ANGULAR_VELOCITY_X = "avx";
      public const string ANGULAR_VELOCITY_Y = "avy";
      public const string ANGULAR_VELOCITY_Z = "avz";
      public const string OFFSET_POSITION_X = "opx";
      public const string OFFSET_POSITION_Y = "opy";
      public const string OFFSET_POSITION_Z = "opz";
    }
  }
}
