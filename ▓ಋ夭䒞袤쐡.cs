// Decompiled with JetBrains decompiler
// Type: ▓ಋ夭䒞袤쐡
// Assembly: REMAP_HONDA_KLINE, Version=6.8.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 86BD3BB8-DA56-458E-9BB5-F30C432AA5F0
// Assembly location: C:\Program Files (x86)\AUTOSHOP VIETNAM\REMAP_HONDA_KLINE\REMAP_HONDA_KLINE.exe

using System;
using System.Runtime.InteropServices;

internal static class \u2593ಋ\uE555夭䒞袤\uE8B4쐡
{
  [DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  private static extern int 䏌庣\uEAC5읽\uFFFDꍻໃ䞢(
    IntPtr ProcessHandle,
    int ProcessInformationClass,
    byte[] ProcessInformation,
    uint ProcessInformationLength,
    out int ReturnLength);

  [DllImport("ntdll.dll", EntryPoint = "NtSetInformationProcess", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  private static extern uint 갰寑憫\uE79C鱼좶諡켣(
    IntPtr ProcessHandle,
    int ProcessInformationClass,
    byte[] ProcessInformation,
    uint ProcessInformationLength);

  [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
  private static extern bool 谞丞劣멠萞뿢\u223A轻(IntPtr hObject);

  [DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent")]
  private static extern bool 琸軶쫆藕墌脱拘ꦚ();

  [DllImport("kernel32.dll", EntryPoint = "OutputDebugString")]
  private static extern int 浯ૂ꽒\u2FB6옞硤勵껅(string str);

  public static void ㆶ\uE6F0镘ᬗ赞녘脕쨴()
  {
    // ISSUE: unable to decompile the method.
  }

  private static void \uAA53\u18AC\uA4B1䴀짶\u2A6F\uE72A\uF181(object thread)
  {
    // ISSUE: unable to decompile the method.
  }
}
