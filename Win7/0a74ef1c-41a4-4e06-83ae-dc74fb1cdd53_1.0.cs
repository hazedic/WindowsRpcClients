//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\schedsvc.dll
// Interface ID: 0a74ef1c-41a4-4e06-83ae-dc74fb1cdd53
// Interface Version: 1.0



namespace rpc_0a74ef1c_41a4_4e06_83ae_dc74fb1cdd53_1_0
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
            m.WriteEnum16(Member4);
            m.WriteInt32(Member8);
            m.WriteUInt3264(Member10);
            m.WriteUInt3264(Member18);
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
            Member10 = u.ReadUInt3264();
            Member18 = u.ReadUInt3264();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member10;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member18;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, int Member8, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member10, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member18)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
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
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
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
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4, int Member8, int MemberC, int Member10, int Member14, int Member18, int Member1C)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("0a74ef1c-41a4-4e06-83ae-dc74fb1cdd53", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int ItSrvRegisterIdleTask(string p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, Struct_0 p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.Write_0(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public void ItSrvUnregisterIdleTask(string p0, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadContextHandle();
        }
        public int ItSrvProcessIdleTasks(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int Initialize(string p0, Struct_1 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.Write_1(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

