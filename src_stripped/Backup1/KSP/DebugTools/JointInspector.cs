// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.JointInspector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace KSP.DebugTools
{
  public class JointInspector : MonoBehaviour
  {
    [Header("Primary Joint")]
    public GameObject PrimaryObject;
    public ConfigurableJoint PrimaryJoint;
    public Vector3 PrimaryCurrentForce;
    public Vector3 PrimaryCurrentTorque;
    [Header("Secondary Joint")]
    public GameObject SecondaryObject;
    [Header("Angle measurement")]
    public JointInspector.JointDirectionEnum PrimaryJointDirection;
    public JointInspector.JointDirectionEnum SecondaryJointDirection;
    public float Angle;
    [Header("Recording")]
    public string FileName;
    public bool StartRecording;
    public bool StopRecording;
    private const string OUTPUT_DIR = "DebugJointData";
    private string _outputPath;
    private StringBuilder _output;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetDirection(Transform t, JointInspector.JointDirectionEnum jointDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JointInspector() => throw null;

    public enum JointDirectionEnum
    {
      XPlus,
      XMinus,
      YPlus,
      YMinus,
      ZPlus,
      ZMinus,
    }
  }
}
