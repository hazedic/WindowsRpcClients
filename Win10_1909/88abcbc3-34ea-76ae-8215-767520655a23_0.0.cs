//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\ResourcePolicyServer.dll
// Interface ID: 88abcbc3-34ea-76ae-8215-767520655a23
// Interface Version: 0.0



namespace rpc_88abcbc3_34ea_76ae_8215_767520655a23_0_0
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
        public void Write_2(Struct_2[] p0, long p1)
        {
            WriteConformantStructArray<Struct_2>(p0, p1);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_5(System.Guid[] p0, long p1)
        {
            WriteConformantArray<System.Guid>(p0, p1);
        }
        public void Write_6(System.Guid[] p0, long p1)
        {
            WriteConformantArray<System.Guid>(p0, p1);
        }
        public void Write_7(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_8(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_9(byte[] p0, long p1)
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
        public Struct_2[] Read_2()
        {
            return ReadConformantStructArray<Struct_2>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
        }
        public System.Guid[] Read_5()
        {
            return ReadConformantArray<System.Guid>();
        }
        public System.Guid[] Read_6()
        {
            return ReadConformantArray<System.Guid>();
        }
        public byte[] Read_7()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_8()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_9()
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<Struct_2[], long>(Member8, new System.Action<Struct_2[], long>(m.Write_2), Member10);
            m.WriteInt32(Member10);
            m.WriteEnum16(Member14);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member28);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<Struct_2[]>(new System.Func<Struct_2[]>(u.Read_2), false);
            Member10 = u.ReadInt32();
            Member14 = u.ReadEnum16();
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_2[]> Member8;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member14;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public int Member28;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, Struct_2[] Member8, int Member10, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member14, string Member18, string Member20, int Member28)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
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
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, string Member8)
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
                base("88abcbc3-34ea-76ae-8215-767520655a23", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int GcsSrv_GetGameConfigSize(System.Guid p0, ref int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameConfig(System.Guid p0, ref int p1, ref byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p1));
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadInt32();
            p2 = u.Read_3();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameConfigSizeForClientProcess(ref int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameConfigForClientProcess(ref int p0, out byte[] p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadInt32();
            p1 = u.Read_4();
            return u.ReadInt32();
        }
        public int GcsSrv_ModifyGameConfig(System.Guid p0, Struct_1 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int GcsSrv_AddGameConfig(Struct_1 p0, out System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int GcsSrv_RemoveGameConfig(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameIdByAUMID(string p0, out System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(7, m);
            p1 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameIdByPID(int p0, out System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameIdCount(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(9, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int GcsSrv_GetAllGameIds(ref int p0, ref System.Guid[] p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p0));
            _Unmarshal_Helper u = SendReceive(10, m);
            p0 = u.ReadInt32();
            p1 = u.Read_5();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameIdsByExeNameCount(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(11, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameIdsByExeName(string p0, ref int p1, ref System.Guid[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p1));
            _Unmarshal_Helper u = SendReceive(12, m);
            p1 = u.ReadInt32();
            p2 = u.Read_6();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGameProperty(System.Guid p0, int p1, ref int p2, ref byte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p2));
            _Unmarshal_Helper u = SendReceive(13, m);
            p2 = u.ReadInt32();
            p3 = u.Read_7();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGamePropertySize(System.Guid p0, int p1, ref int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(14, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int GcsSrv_SetGameProperty(System.Guid p0, int p1, int p2, byte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(15, m);
            return u.ReadInt32();
        }
        public int GcsSrv_GetGlobalProperty(int p0, ref int p1, ref byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.Write_3(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p1));
            _Unmarshal_Helper u = SendReceive(16, m);
            p1 = u.ReadInt32();
            p2 = u.Read_3();
            return u.ReadInt32();
        }
        public int GcsSrv_GetGlobalPropertySize(int p0, ref int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(17, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int GcsSrv_SetGlobalProperty(int p0, int p1, byte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.Write_9(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int GcsSrv_SetGamePropertyUserOverride(System.Guid p0, int p1, int p2, byte[] p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.Write_8(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int GcsSrv_GetGamePropertyIsUserOverride(System.Guid p0, int p1, ref int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(20, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

