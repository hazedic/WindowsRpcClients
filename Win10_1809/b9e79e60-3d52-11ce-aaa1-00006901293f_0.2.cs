//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\rpcss.dll
// Interface ID: b9e79e60-3d52-11ce-aaa1-00006901293f
// Interface Version: 0.2



namespace rpc_b9e79e60_3d52_11ce_aaa1_00006901293f_0_2
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_5(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_9(byte[] p0, long p1)
        {
            WriteVaryingArray<byte>(p0, p1);
        }
        public void Write_10(Struct_5[] p0, long p1)
        {
            WriteConformantStructArray<Struct_5>(p0, p1);
        }
        public void Write_11(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
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
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_4()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_5()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public byte[] Read_8()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_9()
        {
            return ReadVaryingArray<byte>();
        }
        public Struct_5[] Read_10()
        {
            return ReadConformantStructArray<Struct_5>();
        }
        public Struct_0[] Read_11()
        {
            return ReadConformantStructArray<Struct_0>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_8();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public byte[] Member4;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member4 = new byte[0];
            return ret;
        }
        public Struct_0(int Member0, byte[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_9();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public byte[] Member4;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member4 = new byte[0];
            return ret;
        }
        public Struct_1(int Member0, byte[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt64(Member0);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public int Member8;
        public int MemberC;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(long Member0, int Member8, int MemberC)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.Read_10();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_5[] Member8;
        public static Struct_4 CreateDefault()
        {
            Struct_4 ret = new Struct_4();
            ret.Member8 = new Struct_5[0];
            return ret;
        }
        public Struct_4(int Member0, Struct_5[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<Struct_1>(Member0, new System.Action<Struct_1>(m.Write_1));
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_1> Member0;
        public int Member8;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(System.Nullable<Struct_1> Member0, int Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.Write_3(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.Read_3();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public System.Guid Member0;
        public Struct_3 Member10;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(System.Guid Member0, Struct_3 Member10)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.Read_11();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_0[] Member8;
        public static Struct_8 CreateDefault()
        {
            Struct_8 ret = new Struct_8();
            ret.Member8 = new Struct_0[0];
            return ret;
        }
        public Struct_8(int Member0, Struct_0[] Member8)
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
                base("b9e79e60-3d52-11ce-aaa1-00006901293f", 0, 2)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int IrotRegister(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, Struct_0 p2, Struct_1 p3, Struct_1 p4, Struct_2 p5, int p6, int p7, out Struct_3 p8, out uint p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.Write_0(p2);
            m.Write_1(p3);
            m.Write_1(p4);
            m.Write_2(p5);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(0, m);
            p8 = u.Read_3();
            p9 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IrotRevoke(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_3 p1, out System.Nullable<Struct_1> p2, out System.Nullable<Struct_1> p3, out int p4, out uint p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_3(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p3 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p4 = u.ReadInt32();
            p5 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IrotIsRunning(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, Struct_0 p2, out uint p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.Write_0(p2);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IrotGetObject(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, int p2, Struct_0 p3, out Struct_3 p4, out System.Nullable<Struct_1> p5, out int p6, out int p7, out uint p8, int p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p2);
            m.Write_0(p3);
            m.WriteInt32(p9);
            _Unmarshal_Helper u = SendReceive(3, m);
            p4 = u.Read_3();
            p5 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p6 = u.ReadInt32();
            p7 = u.ReadInt32();
            p8 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IrotNoteChangeTime(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_3 p1, Struct_2 p2, out uint p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_3(p1);
            m.Write_2(p2);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IrotGetTimeOfLastChange(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, Struct_0 p2, out Struct_2 p3, out uint p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.Write_0(p2);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(5, m);
            p3 = u.Read_2();
            p4 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IrotEnumRunning(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, out System.Nullable<Struct_4> p2, out uint p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(6, m);
            p2 = u.ReadReferentValue<Struct_4>(new System.Func<Struct_4>(u.Read_4), false);
            p3 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IMgotRegister(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, System.Guid p2, Struct_0 p3, Struct_1 p4, int p5, out Struct_7 p6, out uint p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p2);
            m.Write_0(p3);
            m.Write_1(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(7, m);
            p6 = u.Read_6();
            p7 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IMgotRevoke(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_7 p1, out System.Nullable<Struct_1> p2, out int p3, out uint p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_6(p1);
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p3 = u.ReadInt32();
            p4 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IMgotGetObject(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, System.Guid p2, Struct_0 p3, out System.Nullable<Struct_1> p4, out int p5, out int p6, out uint p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p2);
            m.Write_0(p3);
            _Unmarshal_Helper u = SendReceive(9, m);
            p4 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            p5 = u.ReadInt32();
            p6 = u.ReadInt32();
            p7 = u.ReadUInt32();
            return u.ReadInt32();
        }
        public int IMgotEnumRunning(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, System.Guid p2, out System.Nullable<Struct_8> p3, out uint p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p2);
            _Unmarshal_Helper u = SendReceive(10, m);
            p3 = u.ReadReferentValue<Struct_8>(new System.Func<Struct_8>(u.Read_7), false);
            p4 = u.ReadUInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

