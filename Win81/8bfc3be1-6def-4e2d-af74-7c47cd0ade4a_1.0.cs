//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\bisrv.dll
// Interface ID: 8bfc3be1-6def-4e2d-af74-7c47cd0ade4a
// Interface Version: 1.0



namespace rpc_8bfc3be1_6def_4e2d_af74_7c47cd0ade4a_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_1(string[] p0, long p1)
        {
            WriteConformantStringArray(p0, new System.Action<string>(this.WriteTerminatedString), p1);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_4(NtApiDotNet.NtEvent p0)
        {
            WriteSystemHandle<NtApiDotNet.NtEvent>(p0);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public char[] Read_0()
        {
            return ReadConformantArray<char>();
        }
        public string[] Read_1()
        {
            return ReadConformantStringArray(new System.Func<string>(this.ReadConformantVaryingString));
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public sbyte[] Read_3()
        {
            return ReadConformantArray<sbyte>();
        }
        public NtApiDotNet.NtEvent Read_4()
        {
            return ReadSystemHandle<NtApiDotNet.NtEvent>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("8bfc3be1-6def-4e2d-af74-7c47cd0ade4a", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint RBiSrvChangeApplicationStateForPackageName(char[] p0, int p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, out sbyte p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            m.WriteEnum16(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.ReadSByte();
            return u.ReadUInt32();
        }
        public uint RBiSrvChangeApplicationStateForPsmKey(char[] p0, int p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, out sbyte p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            m.WriteEnum16(p2);
            _Unmarshal_Helper u = SendReceive(1, m);
            p3 = u.ReadSByte();
            return u.ReadUInt32();
        }
        public uint RBiSrvChangeSessionState(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvNotifyNewSession(int p0, string[] p1, string[] p2, int p3, byte[] p4, int p5, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<string[], long>(m.Write_1), p0);
            m.WriteReferent(p2, new System.Action<string[], long>(m.Write_1), p0);
            m.WriteInt32(p3);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p4, "p4"), p3);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(3, m);
            p6 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint RBiSrvNotifyEndSession(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint RBiSrvResetActiveSessionForPackage(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvSetActiveSessionForPackage(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvUpdateLockScreenApplications(int p0, string[] p1, string[] p2, sbyte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p0);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvIsApplicationTerminateSensitive(char[] p0, int p1, out sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadSByte();
            return u.ReadUInt32();
        }
        public uint RBiSrvGetActiveBackgroundTasksEvent(char[] p0, int p1, out NtApiDotNet.NtEvent p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            p2 = u.Read_4();
            return u.ReadUInt32();
        }
    }
    #endregion
}

