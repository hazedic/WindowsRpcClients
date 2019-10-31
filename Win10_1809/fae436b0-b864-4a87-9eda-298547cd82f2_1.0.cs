//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\PsmServiceExtHost.dll
// Interface ID: fae436b0-b864-4a87-9eda-298547cd82f2
// Interface Version: 1.0



namespace rpc_fae436b0_b864_4a87_9eda_298547cd82f2_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public int[] Read_1()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_0(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("fae436b0-b864-4a87-9eda-298547cd82f2", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint HamRpcSrvConnectDebugging(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadContextHandle();
            p1 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDisconnect(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDebugOpenPackageHandle(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, byte[] p2, int p3, out long p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p3);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadInt64();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDebugClosePackageHandle(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDebugModeEnable(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDebugTerminatePackage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, NtApiDotNet.Ndr.Marshal.NdrEnum16 p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteEnum16(p2);
            m.WriteEnum16(p3);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDebugQueryPackageState(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            p2 = u.ReadEnum16();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvDebugSuspendPackage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(7, m);
            p2 = u.ReadEnum16();
            return u.ReadUInt32();
        }
    }
    #endregion
}

