//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\gpsvc.dll
// Interface ID: 2eb08e3e-639f-4fba-97b1-14f878961076
// Interface Version: 1.0



namespace rpc_2eb08e3e_639f_4fba_97b1_14f878961076_1_0
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
        public void Write_2(Struct_2[] p0, long p1)
        {
            WriteConformantStructArray<Struct_2>(p0, p1);
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
        public Struct_2[] Read_2()
        {
            return ReadConformantStructArray<Struct_2>();
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
            m.WriteGuid(Member0);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public int Member10;
        public int Member14;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(System.Guid Member0, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member14 = Member14;
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
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member28);
            m.WriteEmbeddedPointer<string>(Member30, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member38, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadInt32();
            Member30 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member38 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public int Member28;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member30;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member38;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, int Member4, string Member8, string Member10, string Member18, string Member20, int Member28, string Member30, string Member38)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("2eb08e3e-639f-4fba-97b1-14f878961076", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint Server_ProcessRefresh(string p0, sbyte p1, sbyte p2, sbyte p3, int p4, out Struct_0 p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteSByte(p1);
            m.WriteSByte(p2);
            m.WriteSByte(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(0, m);
            p5 = u.Read_0();
            return u.ReadUInt32();
        }
        // async
        public uint Server_RegisterForNotification(string p0, int p1, int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(1, m);
            p3 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint Server_CheckRegisterForNotification(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadUInt32();
        }
        // async
        public uint Server_LockPolicySection(string p0, int p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(3, m);
            p3 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint Server_UnLockPolicySection(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint Server_GetGroupPolicyObjectList(string p0, string p1, string p2, int p3, out Struct_2[] p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(5, m);
            p4 = u.ReadReferent<Struct_2[]>(new System.Func<Struct_2[]>(u.Read_2), false);
            p5 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint Server_GetAppliedGroupPolicyObjectList(int p0, string p1, string p2, string p3, out Struct_2[] p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"));
            _Unmarshal_Helper u = SendReceive(6, m);
            p4 = u.ReadReferent<Struct_2[]>(new System.Func<Struct_2[]>(u.Read_2), false);
            p5 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint Server_GenerateGroupPolicyNotification(int p0, string p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadUInt32();
        }
    }
    #endregion
}

