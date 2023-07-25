// Decompiled with JetBrains decompiler
// Type: XboxOneController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

public class XboxOneController : IPlatformController
{
  private KeyBinding buttonXboxOne;
  private AxisBinding axisXboxOne;
  private const float doubleTapInterval = 0.2f;
  private float lastButtonKeyDownTime;
  private bool isPositive;
  private bool isFullAxis;
  private bool isPressedOnLastUpdate_GetKeyDown;
  private bool isPressedOnLastUpdate_GetKeyUp;
  private bool isDoubleTapPrePressed;
  private bool isDoubleTapSecondPressed;
  private float firstKeyUpInterval;
  private float secondKeyDownInterval;
  private float lastKeyDownTime;
  private float TopTapCheckValue;
  private float BottomTapCheckValue;
  private int currentFrameCountForGetKeyUp;
  private bool getAxisKeyUp;
  private int currentFrameCountForGetKeyDown;
  private bool getAxisKeyDown;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Init(ConsoleButtons key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKey() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetButtonDoubleTapDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetAxisDoubleTapDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDoubleTapDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetButtonKey() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetAxisKey() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetButtonKeyUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetAxisKeyUp() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetButtonKeyDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetAxisKeyDown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public XboxOneController() => throw null;
}
