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
// Interface ID: e60c73e6-88f9-11cf-9af1-0020af6e72f4
// Interface Version: 2.0



namespace rpc_e60c73e6_88f9_11cf_9af1_0020af6e72f4_2_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(short[] p0, long p1)
        {
            WriteConformantArray<short>(p0, p1);
        }
        public void Write_9(NtApiDotNet.Ndr.Marshal.NdrUnsupported p0)
        {
            WriteUnsupported(p0, "FC_USER_MARSHAL - LOCAL_HSTRING");
        }
        public void Write_10(short[] p0, long p1)
        {
            WriteConformantArray<short>(p0, p1);
        }
        public void Write_11(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_12(short[] p0, long p1)
        {
            WriteConformantArray<short>(p0, p1);
        }
        public void Write_13(Struct_3[] p0, long p1)
        {
            WriteConformantStructArray<Struct_3>(p0, p1);
        }
        public void Write_14(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_15(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 5);
        }
        public void Write_16(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_17(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 4);
        }
        public void Write_18(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_19(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_20(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
        }
        public void Write_21(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_22(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
        }
        public void Write_23(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_24(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_25(Struct_5[] p0, long p1)
        {
            WriteConformantStructArray<Struct_5>(p0, p1);
        }
        public void Write_26(Struct_5[] p0, long p1)
        {
            WriteConformantStructArray<Struct_5>(p0, p1);
        }
        public void Write_27(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_28(long[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<long>(p0, p1, p2);
        }
        public void Write_29(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
        }
        public void Write_30(long[] p0, long p1)
        {
            WriteConformantArray<long>(p0, p1);
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
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public short[] Read_8()
        {
            return ReadConformantArray<short>();
        }
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Read_9()
        {
            return ReadUnsupported("FC_USER_MARSHAL - LOCAL_HSTRING");
        }
        public short[] Read_10()
        {
            return ReadConformantArray<short>();
        }
        public long[] Read_11()
        {
            return ReadConformantArray<long>();
        }
        public short[] Read_12()
        {
            return ReadConformantArray<short>();
        }
        public Struct_3[] Read_13()
        {
            return ReadConformantStructArray<Struct_3>();
        }
        public System.Guid[] Read_14()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public int[] Read_15()
        {
            return ReadFixedPrimitiveArray<int>(5);
        }
        public byte[] Read_16()
        {
            return ReadConformantArray<byte>();
        }
        public int[] Read_17()
        {
            return ReadFixedPrimitiveArray<int>(4);
        }
        public byte[] Read_18()
        {
            return ReadConformantArray<byte>();
        }
        public long[] Read_19()
        {
            return ReadConformantArray<long>();
        }
        public Struct_4[] Read_20()
        {
            return ReadConformantStructArray<Struct_4>();
        }
        public int[] Read_21()
        {
            return ReadConformantArray<int>();
        }
        public Struct_4[] Read_22()
        {
            return ReadConformantStructArray<Struct_4>();
        }
        public long[] Read_23()
        {
            return ReadConformantArray<long>();
        }
        public long[] Read_24()
        {
            return ReadConformantArray<long>();
        }
        public Struct_5[] Read_25()
        {
            return ReadConformantStructArray<Struct_5>();
        }
        public Struct_5[] Read_26()
        {
            return ReadConformantStructArray<Struct_5>();
        }
        public sbyte[] Read_27()
        {
            return ReadConformantArray<sbyte>();
        }
        public long[] Read_28()
        {
            return ReadConformantVaryingArray<long>();
        }
        public long[] Read_29()
        {
            return ReadConformantArray<long>();
        }
        public long[] Read_30()
        {
            return ReadConformantArray<long>();
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
            m.WriteInt64(Member8);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
            m.WriteInt32(Member28);
            m.WriteInt32(Member2C);
            m.WriteInt32(Member30);
            m.WriteInt32(Member34);
            m.WriteInt32(Member38);
            m.WriteInt32(Member3C);
            m.WriteInt32(Member40);
            m.WriteInt32(Member44);
            m.WriteInt32(Member48);
            m.WriteInt32(Member4C);
            m.WriteGuid(Member50);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
            Member28 = u.ReadInt32();
            Member2C = u.ReadInt32();
            Member30 = u.ReadInt32();
            Member34 = u.ReadInt32();
            Member38 = u.ReadInt32();
            Member3C = u.ReadInt32();
            Member40 = u.ReadInt32();
            Member44 = u.ReadInt32();
            Member48 = u.ReadInt32();
            Member4C = u.ReadInt32();
            Member50 = u.ReadGuid();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public long Member8;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public int Member20;
        public int Member24;
        public int Member28;
        public int Member2C;
        public int Member30;
        public int Member34;
        public int Member38;
        public int Member3C;
        public int Member40;
        public int Member44;
        public int Member48;
        public int Member4C;
        public System.Guid Member50;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(
                    int Member0, 
                    long Member8, 
                    int Member10, 
                    int Member14, 
                    int Member18, 
                    int Member1C, 
                    int Member20, 
                    int Member24, 
                    int Member28, 
                    int Member2C, 
                    int Member30, 
                    int Member34, 
                    int Member38, 
                    int Member3C, 
                    int Member40, 
                    int Member44, 
                    int Member48, 
                    int Member4C, 
                    System.Guid Member50)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member24 = Member24;
            this.Member28 = Member28;
            this.Member2C = Member2C;
            this.Member30 = Member30;
            this.Member34 = Member34;
            this.Member38 = Member38;
            this.Member3C = Member3C;
            this.Member40 = Member40;
            this.Member44 = Member44;
            this.Member48 = Member48;
            this.Member4C = Member4C;
            this.Member50 = Member50;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member4 = u.Read_8();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public short Member0;
        public short Member2;
        public short[] Member4;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member4 = new short[0];
            return ret;
        }
        public Struct_2(short Member0, short Member2, short[] Member4)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
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
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt16(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public short Member8;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(string Member0, short Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt64(Member0);
            m.WriteInt64(Member8);
            m.WriteInt64(Member10);
            m.WriteInt32(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt64();
            Member18 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public long Member8;
        public long Member10;
        public int Member18;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(long Member0, long Member8, long Member10, int Member18)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
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
            m.WriteInt64(Member0);
            m.WriteInt64(Member8);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public long Member8;
        public int Member10;
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(long Member0, long Member8, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.Write_6(MemberC);
            m.WriteGuid(Member10);
            m.WriteInt32(Member20);
            m.WriteEmbeddedPointer<Struct_2>(Member28, new System.Action<Struct_2>(m.Write_1));
            m.WriteGuid(Member30);
            m.WriteInt64(Member40);
            m.WriteEnum16(Member48);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member50, "Member50"));
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member58, "Member58"));
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member60, "Member60"));
            m.WriteInt64(Member68);
            m.WriteGuid(Member70);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.Read_6();
            Member10 = u.ReadGuid();
            Member20 = u.ReadInt32();
            Member28 = u.ReadEmbeddedPointer<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            Member30 = u.ReadGuid();
            Member40 = u.ReadInt64();
            Member48 = u.ReadEnum16();
            Member50 = u.Read_9();
            Member58 = u.Read_9();
            Member60 = u.Read_9();
            Member68 = u.ReadInt64();
            Member70 = u.ReadGuid();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public Struct_7 MemberC;
        public System.Guid Member10;
        public int Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_2> Member28;
        public System.Guid Member30;
        public long Member40;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member48;
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Member50;
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Member58;
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Member60;
        public long Member68;
        public System.Guid Member70;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(int Member0, int Member4, int Member8, Struct_7 MemberC, System.Guid Member10, int Member20, System.Nullable<Struct_2> Member28, System.Guid Member30, long Member40, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member48, NtApiDotNet.Ndr.Marshal.NdrUnsupported Member50, NtApiDotNet.Ndr.Marshal.NdrUnsupported Member58, NtApiDotNet.Ndr.Marshal.NdrUnsupported Member60, long Member68, System.Guid Member70)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member40 = Member40;
            this.Member48 = Member48;
            this.Member50 = Member50;
            this.Member58 = Member58;
            this.Member60 = Member60;
            this.Member68 = Member68;
            this.Member70 = Member70;
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
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 2;
        }
        public short Member0;
        public short Member2;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(short Member0, short Member2)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
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
            m.WriteInt32(Member4);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
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
        public int Member4;
        public short[] Member8;
        public static Struct_8 CreateDefault()
        {
            Struct_8 ret = new Struct_8();
            ret.Member8 = new short[0];
            return ret;
        }
        public Struct_8(int Member0, int Member4, short[] Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("e60c73e6-88f9-11cf-9af1-0020af6e72f4", 2, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint _Connect(
                    string p0, 
                    string p1, 
                    System.Nullable<Struct_0> p2, 
                    int p3, 
                    out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4, 
                    out int p5, 
                    out System.Nullable<Struct_2> p6, 
                    out long p7, 
                    int p8, 
                    out long[] p9, 
                    out int p10, 
                    out int p11, 
                    out int p12, 
                    out string p13, 
                    out int p14, 
                    out int p15, 
                    out int p16, 
                    out short[] p17, 
                    out int p18, 
                    out Struct_3[] p19, 
                    out int p20, 
                    out System.Guid[] p21, 
                    out int p22, 
                    out int p23, 
                    out long p24, 
                    out System.Guid p25, 
                    out int[] p26, 
                    out int p27, 
                    out byte[] p28)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<Struct_0>(m.Write_0));
            m.WriteInt32(p3);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(0, m);
            p4 = u.ReadContextHandle();
            p5 = u.ReadInt32();
            p6 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            p7 = u.ReadInt64();
            p9 = u.Read_11();
            p10 = u.ReadInt32();
            p11 = u.ReadInt32();
            p12 = u.ReadInt32();
            p13 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p14 = u.ReadInt32();
            p15 = u.ReadInt32();
            p16 = u.ReadInt32();
            p17 = u.ReadReferent<short[]>(new System.Func<short[]>(u.Read_12), false);
            p18 = u.ReadInt32();
            p19 = u.ReadReferent<Struct_3[]>(new System.Func<Struct_3[]>(u.Read_13), false);
            p20 = u.ReadInt32();
            p21 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_14), false);
            p22 = u.ReadInt32();
            p23 = u.ReadInt32();
            p24 = u.ReadInt64();
            p25 = u.ReadGuid();
            p26 = u.Read_15();
            p27 = u.ReadInt32();
            p28 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_16), false);
            return u.ReadUInt32();
        }
        public uint _SetAppID(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadUInt32();
        }
        public uint GetDefaultSecurityPermissions(out int[] p0, out int p1, out byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.Read_17();
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_18), false);
            return u.ReadUInt32();
        }
        public uint _AllocateReservedIds(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out long[] p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            p2 = u.Read_19();
            p3 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint BulkUpdateOIDs(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, Struct_4[] p2, out int[] p3, int p4, Struct_4[] p5, int p6, long[] p7, int p8, long[] p9, int p10, Struct_5[] p11, int p12, Struct_5[] p13)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.Write_20(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            m.WriteInt32(p4);
            m.Write_22(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p4);
            m.WriteInt32(p6);
            m.Write_23(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"), p6);
            m.WriteInt32(p8);
            m.Write_24(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p9, "p9"), p8);
            m.WriteInt32(p10);
            m.Write_25(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p11, "p11"), p10);
            m.WriteInt32(p12);
            m.Write_26(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p13, "p13"), p12);
            _Unmarshal_Helper u = SendReceive(4, m);
            p3 = u.Read_21();
            return u.ReadUInt32();
        }
        public uint _ClientResolveOXID(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, System.Nullable<Struct_2> p2, out Struct_6 p3, out long p4, out int p5, out sbyte[] p6, out short p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteReferent(p2, new System.Action<Struct_2>(m.Write_1));
            _Unmarshal_Helper u = SendReceive(5, m);
            p3 = u.Read_5();
            p4 = u.ReadInt64();
            p5 = u.ReadInt32();
            p6 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_27), false);
            p7 = u.ReadInt16();
            return u.ReadUInt32();
        }
        public uint _ServerAllocateOXIDAndOIDs(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out long p1, out long p2, int p3, out long[] p4, out int p5, Struct_6 p6, Struct_2 p7, Struct_2 p8, out long p9, out System.Nullable<Struct_2> p10)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p3);
            m.Write_5(p6);
            m.Write_1(p7);
            m.Write_1(p8);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.ReadInt64();
            p2 = u.ReadInt64();
            p4 = u.Read_28();
            p5 = u.ReadInt32();
            p9 = u.ReadInt64();
            p10 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            return u.ReadUInt32();
        }
        public uint ServerAllocateOIDs(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2, long[] p3, int p4, out long[] p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            m.Write_29(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(7, m);
            p5 = u.Read_30();
            p6 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint _ServerFreeOXIDAndOIDs(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2, long[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            m.Write_29(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadUInt32();
        }
        public uint _SetServerOIDFlags(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadUInt32();
        }
        public uint _Disconnect(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(10, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint GetUpdatedResolverBindings(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out System.Nullable<Struct_2> p1, out long p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(11, m);
            p1 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            p2 = u.ReadInt64();
            return u.ReadUInt32();
        }
    }
    #endregion
}

