// Decompiled with JetBrains decompiler
// Type: RTG.RTInputDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public class RTInputDevice : MonoSingleton<RTInputDevice>
  {
    private IInputDevice _inputDevice;

    public IInputDevice Device
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public InputDeviceType DeviceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RTInputDevice() => throw null;
  }
}
