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
// Interface ID: e53d94ca-7464-4839-b044-09a2fb8b3ae5
// Interface Version: 1.0



namespace rpc_e53d94ca_7464_4839_b044_09a2fb8b3ae5_1_0
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
        public void Write_6(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_7(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_8(string p0)
        {
            WriteFixedString(p0, 64);
        }
        public void Write_9(long[] p0)
        {
            WriteFixedPrimitiveArray<long>(p0, 2);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_11(NtApiDotNet.NtProcess p0)
        {
            WriteSystemHandle<NtApiDotNet.NtProcess>(p0);
        }
        public void Write_12(NtApiDotNet.NtProcess p0)
        {
            WriteSystemHandle<NtApiDotNet.NtProcess>(p0);
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
        public Struct_6 Read_6()
        {
            return ReadStruct<Struct_6>();
        }
        public int[] Read_7()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public string Read_8()
        {
            return ReadFixedString(64);
        }
        public long[] Read_9()
        {
            return ReadFixedPrimitiveArray<long>(2);
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
        public NtApiDotNet.NtProcess Read_11()
        {
            return ReadSystemHandle<NtApiDotNet.NtProcess>();
        }
        public NtApiDotNet.NtProcess Read_12()
        {
            return ReadSystemHandle<NtApiDotNet.NtProcess>();
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
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_7();
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
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
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
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(MemberC, "MemberC"));
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8C, "Member8C"));
            m.WriteInt32(Member10C);
            m.WriteInt32(Member110);
            m.WriteInt32(Member114);
            m.Write_2(Member118);
            m.Write_0(Member180);
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
            MemberC = u.Read_8();
            Member8C = u.Read_8();
            Member10C = u.ReadInt32();
            Member110 = u.ReadInt32();
            Member114 = u.ReadInt32();
            Member118 = u.Read_2();
            Member180 = u.Read_0();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public string MemberC;
        public string Member8C;
        public int Member10C;
        public int Member110;
        public int Member114;
        public Struct_2 Member118;
        public Struct_0 Member180;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.MemberC = new string('\0', 64);
            ret.Member8C = new string('\0', 64);
            return ret;
        }
        public Struct_1(int Member0, int Member4, int Member8, string MemberC, string Member8C, int Member10C, int Member110, int Member114, Struct_2 Member118, Struct_0 Member180)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member8C = Member8C;
            this.Member10C = Member10C;
            this.Member110 = Member110;
            this.Member114 = Member114;
            this.Member118 = Member118;
            this.Member180 = Member180;
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
            m.Write_3(Member0);
            m.WriteInt32(Member20);
            m.WriteByte(Member24);
            m.Write_4(Member28);
            m.WriteInt16(Member60);
            m.WriteByte(Member62);
            m.WriteInt32(Member64);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_3();
            Member20 = u.ReadInt32();
            Member24 = u.ReadByte();
            Member28 = u.Read_4();
            Member60 = u.ReadInt16();
            Member62 = u.ReadByte();
            Member64 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_3 Member0;
        public int Member20;
        public byte Member24;
        public Struct_4 Member28;
        public short Member60;
        public byte Member62;
        public int Member64;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(Struct_3 Member0, int Member20, byte Member24, Struct_4 Member28, short Member60, byte Member62, int Member64)
        {
            this.Member0 = Member0;
            this.Member20 = Member20;
            this.Member24 = Member24;
            this.Member28 = Member28;
            this.Member60 = Member60;
            this.Member62 = Member62;
            this.Member64 = Member64;
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
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteInt32(Member10);
            m.WriteInt64(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_9();
            Member10 = u.ReadInt32();
            Member18 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long[] Member0;
        public int Member10;
        public long Member18;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new long[2];
            return ret;
        }
        public Struct_3(long[] Member0, int Member10, long Member18)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
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
            m.WriteInt64(Member18);
            m.WriteInt64(Member20);
            m.WriteInt64(Member28);
            m.WriteInt32(Member30);
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
            Member18 = u.ReadInt64();
            Member20 = u.ReadInt64();
            Member28 = u.ReadInt64();
            Member30 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public long Member8;
        public long Member10;
        public long Member18;
        public long Member20;
        public long Member28;
        public int Member30;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(long Member0, long Member8, long Member10, long Member18, long Member20, long Member28, int Member30)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
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
        public static Struct_5 CreateDefault()
        {
            return new Struct_5();
        }
        public Struct_5(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
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
            m.WriteByte(Member0);
            m.WriteByte(Member1);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadByte();
            Member1 = u.ReadByte();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public byte Member0;
        public byte Member1;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(byte Member0, byte Member1)
        {
            this.Member0 = Member0;
            this.Member1 = Member1;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("e53d94ca-7464-4839-b044-09a2fb8b3ae5", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint HamRpcSrvConnect(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out Struct_0 p1)
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
        public uint HamRpcSrvCreateActivity(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, byte[] p2, int p3, int p4, int p5, long p6, Struct_1 p7, NtApiDotNet.NtProcess p8, out long p9)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p3);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteInt64(p6);
            m.Write_1(p7);
            m.Write_11(p8);
            _Unmarshal_Helper u = SendReceive(2, m);
            p9 = u.ReadInt64();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvCreateActivityForProcess(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.NtProcess p1, Struct_1 p2, out long p3, ref System.Nullable<sbyte> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_12(p1);
            m.Write_1(p2);
            m.WriteReferent(p4, new System.Action<sbyte>(m.WriteSByte));
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.ReadInt64();
            p4 = u.ReadReferentValue<sbyte>(new System.Func<sbyte>(u.ReadSByte), false);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvCreateAutoRestartActivity(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, byte[] p2, int p3, int p4, int p5, long p6, Struct_1 p7, int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p3);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteInt64(p6);
            m.Write_1(p7);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvStartActivityAsync(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, System.Nullable<Struct_1> p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteEnum16(p2);
            m.WriteReferent(p3, new System.Action<Struct_1>(m.Write_1));
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvStopActivity(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvUpdateActivityProperties(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, Struct_5 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.Write_5(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvTerminateActivityHost(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, NtApiDotNet.Ndr.Marshal.NdrEnum16 p2, NtApiDotNet.Ndr.Marshal.NdrEnum16 p3, ref System.Nullable<long> p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteEnum16(p2);
            m.WriteEnum16(p3);
            m.WriteReferent(p4, new System.Action<long>(m.WriteInt64));
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(8, m);
            p4 = u.ReadReferentValue<long>(new System.Func<long>(u.ReadInt64), false);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvSetExternalResourcePriority(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, Struct_6 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.Write_6(p2);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvResetExternalResourcePriority(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, byte p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteByte(p2);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvCloseActivity(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvIsHostBeingDebugged(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, string p1, byte[] p2, int p3, int p4, int p5, long p6, out sbyte p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p3);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteInt64(p6);
            _Unmarshal_Helper u = SendReceive(12, m);
            p7 = u.ReadSByte();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvTerminateHostOnProcessExit(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, long p1, long p2, NtApiDotNet.NtProcess p3, NtApiDotNet.Ndr.Marshal.NdrEnum16 p4, byte p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt64(p1);
            m.WriteInt64(p2);
            m.Write_12(p3);
            m.WriteEnum16(p4);
            m.WriteByte(p5);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadUInt32();
        }
        public uint HamRpcSrvGetApplicationInterruptiveUIState(string p0, byte[] p1, int p2, int p3, out sbyte p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(14, m);
            p4 = u.ReadSByte();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvGetPackageInterruptiveUIState(string p0, byte[] p1, int p2, int p3, out sbyte p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(15, m);
            p4 = u.ReadSByte();
            return u.ReadUInt32();
        }
        public uint HamRpcSrvGetInterruptiveUIStateForAumid(string p0, byte[] p1, int p2, int p3, out sbyte p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(16, m);
            p4 = u.ReadSByte();
            return u.ReadUInt32();
        }
    }
    #endregion
}

