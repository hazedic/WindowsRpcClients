//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\SystemEventsBrokerServer.dll
// Interface ID: 9b008953-f195-4bf9-bde0-4471971e58ed
// Interface Version: 1.0



namespace rpc_9b008953_f195_4bf9_bde0_4471971e58ed_1_0
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
        public void Write_2(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_3(System.Guid[] p0, long p1)
        {
            WriteConformantArrayCallback<System.Guid>(p0, new System.Action<System.Guid>(this.WriteGuid), p1);
        }
        public void Write_4(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_5(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public System.Guid[] Read_2()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public System.Guid[] Read_3()
        {
            return ReadConformantArrayCallback<System.Guid>(new System.Func<System.Guid>(this.ReadGuid));
        }
        public sbyte[] Read_4()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_5()
        {
            return ReadConformantArray<sbyte>();
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
            m.WriteInt64(Member0);
            m.WriteInt32(Member8);
            m.WriteEnum16(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt64();
            Member8 = u.ReadInt32();
            MemberC = u.ReadEnum16();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public long Member0;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC;
        public int Member10;
        public int Member14;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(long Member0, int Member8, NtApiDotNet.Ndr.Marshal.NdrEnum16 MemberC, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
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
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("9b008953-f195-4bf9-bde0-4471971e58ed", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint SebiEnumerateEvents(string p0, out int p1, out System.Guid[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_2), false);
            return u.ReadUInt32();
        }
        public uint _SebiEnumerateEventsByType(string p0, int p1, int p2, out int p3, out System.Guid[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(1, m);
            p3 = u.ReadInt32();
            p4 = u.ReadReferent<System.Guid[]>(new System.Func<System.Guid[]>(u.Read_3), false);
            return u.ReadUInt32();
        }
        public uint _SebiQueryEventData(string p0, System.Guid p1, out Struct_1 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            p2 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint SebiQueryEventPackage(System.Guid p0, out string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadUInt32();
        }
        public uint _SebiSignalSyncEventEx(string p0, System.Guid p1, int p2, int p3, sbyte[] p4, int p5, System.Nullable<System.Guid> p6, int p7, out NtApiDotNet.Ndr.Marshal.NdrEnum16 p8)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            m.WriteReferent(p4, new System.Action<sbyte[], long>(m.Write_4), p5);
            m.WriteInt32(p5);
            m.WriteReferent(p6, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteInt32(p7);
            _Unmarshal_Helper u = SendReceive(4, m);
            p8 = u.ReadEnum16();
            return u.ReadUInt32();
        }
        public uint SebiCancelEvent(string p0, System.Guid p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
        public uint SebiGetUserPresenceHistory(Struct_2 p0, out Struct_2 p1, out short p2, out short p3, out sbyte[] p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_1(p0);
            _Unmarshal_Helper u = SendReceive(6, m);
            p1 = u.Read_1();
            p2 = u.ReadInt16();
            p3 = u.ReadInt16();
            p4 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_5), false);
            return u.ReadUInt32();
        }
    }
    #endregion
}

