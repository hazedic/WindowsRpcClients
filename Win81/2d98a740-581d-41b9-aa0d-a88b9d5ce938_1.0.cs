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
// Interface ID: 2d98a740-581d-41b9-aa0d-a88b9d5ce938
// Interface Version: 1.0



namespace rpc_2d98a740_581d_41b9_aa0d_a88b9d5ce938_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
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
        public void Write_5(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_6(Struct_1[] p0)
        {
            WriteFixedStructArray<Struct_1>(p0, 12);
        }
        public void Write_7(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_8(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 6);
        }
        public void Write_9(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_10(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_11(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_12(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_13(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_14(Struct_2[] p0, long p1)
        {
            WriteConformantStructArray<Struct_2>(p0, p1);
        }
        public void Write_15(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_16(Struct_2[] p0, long p1)
        {
            WriteConformantStructArray<Struct_2>(p0, p1);
        }
        public void Write_17(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_18(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_19(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_20(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_21(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_22(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_23(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_24(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_25(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_26(NtApiDotNet.Ndr.Marshal.NdrUnsupported p0)
        {
            WriteUnsupported(p0, "FC_BOGUS_ARRAY -  GUID*[]");
        }
        public void Write_27(byte[] p0, long p1)
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
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
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
        public int[] Read_5()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public Struct_1[] Read_6()
        {
            return ReadFixedStructArray<Struct_1>(12);
        }
        public int[] Read_7()
        {
            return ReadConformantArray<int>();
        }
        public sbyte[] Read_8()
        {
            return ReadFixedPrimitiveArray<sbyte>(6);
        }
        public char[] Read_9()
        {
            return ReadConformantArray<char>();
        }
        public byte[] Read_10()
        {
            return ReadConformantArray<byte>();
        }
        public char[] Read_11()
        {
            return ReadConformantArray<char>();
        }
        public char[] Read_12()
        {
            return ReadConformantArray<char>();
        }
        public byte[] Read_13()
        {
            return ReadConformantArray<byte>();
        }
        public Struct_2[] Read_14()
        {
            return ReadConformantStructArray<Struct_2>();
        }
        public char[] Read_15()
        {
            return ReadConformantArray<char>();
        }
        public Struct_2[] Read_16()
        {
            return ReadConformantStructArray<Struct_2>();
        }
        public char[] Read_17()
        {
            return ReadConformantArray<char>();
        }
        public byte[] Read_18()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_19()
        {
            return ReadConformantArray<byte>();
        }
        public System.Guid[] Read_20()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public int[] Read_21()
        {
            return ReadConformantArray<int>();
        }
        public char[] Read_22()
        {
            return ReadConformantArray<char>();
        }
        public byte[] Read_23()
        {
            return ReadConformantArray<byte>();
        }
        public System.Guid[] Read_24()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public byte[] Read_25()
        {
            return ReadConformantArray<byte>();
        }
        public NtApiDotNet.Ndr.Marshal.NdrUnsupported Read_26()
        {
            return ReadUnsupported("FC_BOGUS_ARRAY -  GUID*[]");
        }
        public byte[] Read_27()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_5();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_1(int[] Member0)
        {
            this.Member0 = Member0;
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
            m.WriteEmbeddedPointer<System.Guid>(Member0, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteSByte(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            Member8 = u.ReadSByte();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<System.Guid> Member0;
        public sbyte Member8;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(System.Nullable<System.Guid> Member0, sbyte Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
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
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_1[] Member0;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new Struct_1[12];
            return ret;
        }
        public Struct_3(Struct_1[] Member0)
        {
            this.Member0 = Member0;
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
            m.WriteByte(Member0);
            m.WriteByte(Member1);
            m.Write_4(Member2);
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member1);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadByte();
            Member1 = u.ReadByte();
            Member2 = u.Read_4();
            Member8 = u.Read_7();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public byte Member0;
        public byte Member1;
        public Struct_5 Member2;
        public int[] Member8;
        public static Struct_4 CreateDefault()
        {
            Struct_4 ret = new Struct_4();
            ret.Member8 = new int[0];
            return ret;
        }
        public Struct_4(byte Member0, byte Member1, Struct_5 Member2, int[] Member8)
        {
            this.Member0 = Member0;
            this.Member1 = Member1;
            this.Member2 = Member2;
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
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_8();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public static Struct_5 CreateDefault()
        {
            Struct_5 ret = new Struct_5();
            ret.Member0 = new sbyte[6];
            return ret;
        }
        public Struct_5(sbyte[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("2d98a740-581d-41b9-aa0d-a88b9d5ce938", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint RBiSrvActivateDeferredWorkItem(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvActivateInBackground(out System.Guid p0, char[] p1, int p2, byte[] p3, int p4, char[] p5, int p6, char[] p7, int p8, int p9, int p10, System.Nullable<System.Guid> p11, byte[] p12, int p13)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.Write_10(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p4);
            m.WriteInt32(p4);
            m.Write_11(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p6);
            m.WriteInt32(p6);
            m.Write_12(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p7, "p7"), p8);
            m.WriteInt32(p8);
            m.WriteInt32(p9);
            m.WriteInt32(p10);
            m.WriteReferent(p11, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p12, new System.Action<byte[], long>(m.Write_13), p13);
            m.WriteInt32(p13);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadGuid();
            return u.ReadUInt32();
        }
        public uint RBiSrvActivateWorkItem(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvAssociateActivationProxy(out System.Guid p0, out Struct_1 p1, System.Guid p2, Struct_2[] p3, int p4, int p5, char[] p6, int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p2);
            m.WriteReferent(p3, new System.Action<Struct_2[], long>(m.Write_14), p4);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<char[], long>(m.Write_15), p7);
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadGuid();
            p1 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint RBiSrvAssociateApplicationExtensionClass(out System.Guid p0, char[] p1, int p2, System.Guid p3, Struct_2[] p4, int p5, int p6, char[] p7, int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteReferent(p4, new System.Action<Struct_2[], long>(m.Write_16), p5);
            m.WriteInt32(p5);
            m.WriteInt32(p6);
            m.WriteReferent(p7, new System.Action<char[], long>(m.Write_12), p8);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadGuid();
            return u.ReadUInt32();
        }
        public uint RBiSrvCancelWorkItem(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvCreateEventForPackageName(out System.Guid p0, System.Guid p1, char[] p2, int p3, byte[] p4, int p5, int p6, byte[] p7, int p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p1);
            m.WriteReferent(p2, new System.Action<char[], long>(m.Write_17), p3);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<byte[], long>(m.Write_18), p5);
            m.WriteInt32(p5);
            m.WriteInt32(p6);
            m.WriteReferent(p7, new System.Action<byte[], long>(m.Write_19), p8);
            m.WriteInt32(p8);
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadGuid();
            return u.ReadUInt32();
        }
        public uint RBiSrvDeleteEvent(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvDisassociateWorkItem(System.Guid p0, sbyte p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteSByte(p1);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvDiscardPendingActivations(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvEnumerateBrokeredEvents(System.Guid p0, out int p1, out System.Guid[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(10, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_20), false);
            return u.ReadUInt32();
        }
        public uint RBiSrvEnumerateUserSessions(out int p0, out int[] p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(11, m);
            p0 = u.ReadInt32();
            p1 = u.ReadReferent<int[]>(new System.Func<int[]>(u.Read_21), false);
            return u.ReadUInt32();
        }
        public uint RBiSrvEnumerateWorkItemsForPackageName(char[] p0, int p1, byte[] p2, int p3, int p4, out int p5, out System.Guid[] p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char[], long>(m.Write_22), p1);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<byte[], long>(m.Write_23), p3);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(12, m);
            p5 = u.ReadInt32();
            p6 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_24), false);
            return u.ReadUInt32();
        }
        public uint RBiSrvQueryBrokeredEvent(System.Guid p0, out int p1, out byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(13, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_25), false);
            return u.ReadUInt32();
        }
        public uint RBiSrvQuerySystemStateBroadcastChannels(out Struct_3 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(14, m);
            p0 = u.Read_2();
            return u.ReadUInt32();
        }
        public uint RBiSrvQueryWorkItem(System.Guid p0, out int p1, out byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_25), false);
            return u.ReadUInt32();
        }
        public uint RBiSrvQueryUserSession(int p0, out System.Nullable<Struct_4> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            p1 = u.ReadReferentValue<Struct_4>(new System.Func<Struct_4>(u.Read_3), false);
            return u.ReadUInt32();
        }
        public uint RBiSrvSignalEvent(System.Guid p0, System.Nullable<sbyte> p1, System.Nullable<System.Guid> p2, byte[] p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteReferent(p1, new System.Action<sbyte>(m.WriteSByte));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_10), p4);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvSignalMultipleEvents(NtApiDotNet.Ndr.Marshal.NdrUnsupported p0, int p1, System.Nullable<sbyte> p2, System.Nullable<System.Guid> p3, byte[] p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_26(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<sbyte>(m.WriteSByte));
            m.WriteReferent(p3, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p4, new System.Action<byte[], long>(m.Write_18), p5);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvUpdateEventFlags(System.Guid p0, int p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadUInt32();
        }
        public uint RBiSrvUpdateEventInformation(System.Guid p0, byte[] p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteReferent(p1, new System.Action<byte[], long>(m.Write_27), p2);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadUInt32();
        }
    }
    #endregion
}

