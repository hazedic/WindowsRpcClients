//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\DMPushRouterCore.dll
// Interface ID: 795b6bf9-97b6-4f89-bd8d-2f42bbbe996e
// Interface Version: 0.0



namespace rpc_795b6bf9_97b6_4f89_bd8d_2f42bbbe996e_0_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
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
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<byte[], long>(Member10, new System.Action<byte[], long>(m.Write_1), Member18);
            m.WriteInt32(Member18);
            m.WriteEnum16(Member1C);
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<byte[], long>(Member28, new System.Action<byte[], long>(m.Write_2), Member30);
            m.WriteInt32(Member30);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_1), false);
            Member18 = u.ReadInt32();
            Member1C = u.ReadEnum16();
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_2), false);
            Member30 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member10;
        public int Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member1C;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member28;
        public int Member30;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, string Member8, byte[] Member10, int Member18, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member1C, string Member20, byte[] Member28, int Member30)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("795b6bf9-97b6-4f89-bd8d-2f42bbbe996e", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcPushRouter_Open(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, string p2, out string p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadContextHandle();
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int RpcPushRouter_Close(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcPushRouter_GetPushMessage(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out string p1, out int p2, out byte[] p3, out int p4, ref string p5, ref string p6, ref System.Nullable<NtApiDotNet.Ndr.Marshal.NdrEnum16> p7, out int p8, out byte[] p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p5, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p6, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p7, new System.Action<NtApiDotNet.Ndr.Marshal.NdrEnum16>(m.WriteEnum16));
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadInt32();
            p3 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_3), false);
            p4 = u.ReadInt32();
            p5 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p6 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p7 = u.ReadReferentValue<NtApiDotNet.Ndr.Marshal.NdrEnum16>(new System.Func<NtApiDotNet.Ndr.Marshal.NdrEnum16>(u.ReadEnum16), false);
            p8 = u.ReadInt32();
            p9 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_4), false);
            return u.ReadInt32();
        }
        public int RpcPushRouter_SubmitPush(Struct_0 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

