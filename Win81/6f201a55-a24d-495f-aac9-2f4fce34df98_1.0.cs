//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\iphlpsvc.dll
// Interface ID: 6f201a55-a24d-495f-aac9-2f4fce34df98
// Interface Version: 1.0



namespace rpc_6f201a55_a24d_495f_aac9_2f4fce34df98_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
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
        public sbyte[] Read_1()
        {
            return ReadConformantArray<sbyte>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
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
            m.WriteInt16(Member0);
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_1), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_1), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member8 = new sbyte[0];
            return ret;
        }
        public Struct_0(short Member0, sbyte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("6f201a55-a24d-495f-aac9-2f4fce34df98", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcSrvCpRegisterProviderInstance(int p0, ref byte[] p1, int p2, byte[] p3, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.Read_2();
            p4 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSrvCpDeregisterProviderInstance(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSrvCpNotifyConnectivityChange(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, System.Nullable<Struct_0> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteReferent(p2, new System.Action<Struct_0>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int RpcSrvCpQueryPeerLinkInformation(int p0, byte[] p1, out sbyte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.ReadSByte();
            return u.ReadInt32();
        }
        public int RpcSrvCpQueryProviderSubscriptionInformation(long p0, out int p1, out byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_4), false);
            return u.ReadInt32();
        }
        public int RpcSrvCpRegisterConnectivityChangeNotification(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(5, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSrvCpCancelConnectivityChangeNotification(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        // async
        public void RpcSrvCpRequestConnectivityNotification(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadEnum16();
        }
    }
    #endregion
}

