//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\pnrpsvc.dll
// Interface ID: a2d47257-12f7-4beb-8981-0ebfa935c407
// Interface Version: 1.0



namespace rpc_a2d47257_12f7_4beb_8981_0ebfa935c407_1_0
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
        public void Write_5(Union_5 p0, long p1)
        {
            WriteUnion<Union_5>(p0, p1);
        }
        public void Write_6(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_7(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_8(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_9(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_10(Union_10 p0, long p1)
        {
            WriteUnion<Union_10>(p0, p1);
        }
        public void Write_11(string p0)
        {
            WriteFixedString(p0, 128);
        }
        public void Write_12(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
        }
        public void Write_13(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_14(byte[] p0)
        {
            WriteFixedByteArray(p0, 16);
        }
        public void Write_15(byte[] p0)
        {
            WriteFixedByteArray(p0, 4);
        }
        public void Write_16(Struct_8[] p0, long p1)
        {
            WriteConformantStructArray<Struct_8>(p0, p1);
        }
        public void Write_17(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
        }
        public void Write_18(Struct_9[] p0, long p1)
        {
            WriteConformantStructArray<Struct_9>(p0, p1);
        }
        public void Write_19(Struct_9[] p0, long p1)
        {
            WriteConformantStructArray<Struct_9>(p0, p1);
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
        public Union_5 Read_5()
        {
            return ReadStruct<Union_5>();
        }
        public Struct_6 Read_6()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_7()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_8()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_9()
        {
            return ReadStruct<Struct_9>();
        }
        public Union_10 Read_10()
        {
            return ReadStruct<Union_10>();
        }
        public string Read_11()
        {
            return ReadFixedString(128);
        }
        public Struct_4[] Read_12()
        {
            return ReadConformantStructArray<Struct_4>();
        }
        public byte[] Read_13()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_14()
        {
            return ReadFixedByteArray(16);
        }
        public byte[] Read_15()
        {
            return ReadFixedByteArray(4);
        }
        public Struct_8[] Read_16()
        {
            return ReadConformantStructArray<Struct_8>();
        }
        public Struct_0[] Read_17()
        {
            return ReadConformantStructArray<Struct_0>();
        }
        public Struct_9[] Read_18()
        {
            return ReadConformantStructArray<Struct_9>();
        }
        public Struct_9[] Read_19()
        {
            return ReadConformantStructArray<Struct_9>();
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
            m.Write_1(Member0);
            m.WriteEnum16(MemberC);
            m.WriteInt32(Member10);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member14, "Member14"));
            m.WriteEnum16(Member114);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            MemberC = u.ReadEnum16();
            Member10 = u.ReadInt32();
            Member14 = u.Read_11();
            Member114 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_1 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC;
        public int Member10;
        public string Member14;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member114;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member14 = new string('\0', 128);
            return ret;
        }
        public Struct_0(Struct_1 Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC, int Member10, string Member14, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member114)
        {
            this.Member0 = Member0;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member114 = Member114;
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
            m.WriteEnum16(Member4);
            m.WriteInt32(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadEnum16();
            Member8 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public int Member8;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, int Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
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
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member10);
            m.WriteEmbeddedPointer<Struct_4[], long>(Member18, new System.Action<Struct_4[], long>(m.Write_12), Member10);
            m.WriteInt32(Member20);
            m.Write_3(Member28);
            m.WriteEmbeddedPointer<string>(Member38, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<Struct_4[]>(new System.Func<Struct_4[]>(u.Read_12), false);
            Member20 = u.ReadInt32();
            Member28 = u.Read_3();
            Member38 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_4[]> Member18;
        public int Member20;
        public Struct_3 Member28;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member38;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(string Member0, string Member8, int Member10, Struct_4[] Member18, int Member20, Struct_3 Member28, string Member38)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member38 = Member38;
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_13), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_13), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(int Member0, byte[] Member8)
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
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.Write_5(Member4, Member0);
            m.WriteInt16(Member14);
            m.WriteInt32(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member4 = u.Read_5();
            Member14 = u.ReadInt16();
            Member18 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public short Member2;
        public Union_5 Member4;
        public short Member14;
        public int Member18;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(short Member0, short Member2, Union_5 Member4, short Member14, int Member18)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member4 = Member4;
            this.Member14 = Member14;
            this.Member18 = Member18;
        }
    }
    public struct Union_5 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            throw new System.NotImplementedException();
        }
        void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
        {
            Selector = ((short)(l));
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Selector);
            if ((Selector == 23))
            {
                m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Arm_23, "Arm_23"));
                goto done;
            }
            if ((Selector == 2))
            {
                m.Write_15(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Arm_2, "Arm_2"));
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_5");
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadInt16();
            if ((Selector == 23))
            {
                Arm_23 = u.Read_14();
                goto done;
            }
            if ((Selector == 2))
            {
                Arm_2 = u.Read_15();
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_5");
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        private short Selector;
        public byte[] Arm_23;
        public byte[] Arm_2;
        public static Union_5 CreateDefault()
        {
            Union_5 ret = new Union_5();
            ret.Arm_23 = new byte[16];
            ret.Arm_2 = new byte[4];
            return ret;
        }
        public Union_5(short Selector, byte[] Arm_23, byte[] Arm_2)
        {
            this.Selector = Selector;
            this.Arm_23 = Arm_23;
            this.Arm_2 = Arm_2;
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
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_14();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public byte[] Member0;
        public static Struct_6 CreateDefault()
        {
            Struct_6 ret = new Struct_6();
            ret.Member0 = new byte[16];
            return ret;
        }
        public Struct_6(byte[] Member0)
        {
            this.Member0 = Member0;
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<Struct_8[], long>(Member8, new System.Action<Struct_8[], long>(m.Write_16), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_8[]>(new System.Func<Struct_8[]>(u.Read_16), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_8[]> Member8;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(int Member0, Struct_8[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_4(Member0);
            m.WriteInt16(Member1C);
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_4();
            Member1C = u.ReadInt16();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_4 Member0;
        public short Member1C;
        public int Member20;
        public int Member24;
        public static Struct_8 CreateDefault()
        {
            return new Struct_8();
        }
        public Struct_8(Struct_4 Member0, short Member1C, int Member20, int Member24)
        {
            this.Member0 = Member0;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member24 = Member24;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.Write_10(Member8, Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.Read_10();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public Union_10 Member8;
        public static Struct_9 CreateDefault()
        {
            return new Struct_9();
        }
        public Struct_9(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, Union_10 Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Union_10 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            throw new System.NotImplementedException();
        }
        void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
        {
            Selector = ((NtApiDotNet.Ndr.Marshal.NdrEnum16)(l));
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Selector);
            if ((Selector == 2))
            {
                m.WriteInt32(Arm_2);
                goto done;
            }
            if ((Selector == 1))
            {
                m.WriteEmbeddedPointer<string>(Arm_1, new System.Action<string>(m.WriteTerminatedString));
                goto done;
            }
            m.WriteEmpty(Arm_Default);
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadEnum16();
            if ((Selector == 2))
            {
                Arm_2 = u.ReadInt32();
                goto done;
            }
            if ((Selector == 1))
            {
                Arm_1 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
                goto done;
            }
            Arm_Default = u.ReadEmpty();
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        private NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector;
        public int Arm_2;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Arm_1;
        public NtApiDotNet.Ndr.Marshal.NdrEmpty Arm_Default;
        public static Union_10 CreateDefault()
        {
            return new Union_10();
        }
        public Union_10(NtApiDotNet.Ndr.Marshal.NdrEnum16 Selector, int Arm_2, string Arm_1, NtApiDotNet.Ndr.Marshal.NdrEmpty Arm_Default)
        {
            this.Selector = Selector;
            this.Arm_2 = Arm_2;
            this.Arm_1 = Arm_1;
            this.Arm_Default = Arm_Default;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("a2d47257-12f7-4beb-8981-0ebfa935c407", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PnrpRpcInitializeCloudList(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, ref string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadContextHandle();
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int PnrpRpcGetCloudList(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out Struct_0[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<Struct_0[]>(new System.Func<Struct_0[]>(u.Read_17), false);
            return u.ReadInt32();
        }
        public int PnrpRpcShutdownCloudList(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PnrpRpcClientInitialize(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PnrpRpcClientUninitialize(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PnrpRpcRegister(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, string p2, string p3, Struct_2 p4, System.Nullable<Struct_6> p5, out Struct_6 p6, ref string p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteReferent(p3, new System.Action<string>(m.WriteTerminatedString));
            m.Write_2(p4);
            m.WriteReferent(p5, new System.Action<Struct_6>(m.Write_6));
            m.WriteReferent(p7, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(5, m);
            p0 = u.ReadContextHandle();
            p6 = u.Read_6();
            p7 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int PnrpRpcUnregister(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PnrpRpcResolve(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, string p2, string p3, int p4, int p5, NtApiDotNet.Ndr.Marshal.NdrEnum16 p6, System.Nullable<Struct_6> p7, int p8, int p9, int p10, int p11, ref string p12)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteEnum16(p6);
            m.WriteReferent(p7, new System.Action<Struct_6>(m.Write_6));
            m.WriteInt32(p8);
            m.WriteInt32(p9);
            m.WriteInt32(p10);
            m.WriteInt32(p11);
            m.WriteReferent(p12, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(7, m);
            p0 = u.ReadContextHandle();
            p12 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int PnrpRpcGetResolveResult(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, out System.Nullable<Struct_2> p2, ref string p3, ref System.Nullable<Struct_7> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p3, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p4, new System.Action<Struct_7>(m.Write_7));
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadEnum16();
            p2 = u.ReadReferentValue<Struct_2>(new System.Func<Struct_2>(u.Read_2), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p4 = u.ReadReferentValue<Struct_7>(new System.Func<Struct_7>(u.Read_7), false);
            return u.ReadInt32();
        }
        public int PnrpRpcEndResolve(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int PnrpRpcPing()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int PnrpRpcDiagControl(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, int p1, Struct_9[] p2, out int p3, out Struct_9[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<Struct_9[], long>(m.Write_18), p1);
            _Unmarshal_Helper u = SendReceive(11, m);
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<Struct_9[]>(new System.Func<Struct_9[]>(u.Read_19), false);
            return u.ReadInt32();
        }
        public int PnrpRpcHandlePowerEvent(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

