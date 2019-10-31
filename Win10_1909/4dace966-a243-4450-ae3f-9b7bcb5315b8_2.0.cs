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
// Interface ID: 4dace966-a243-4450-ae3f-9b7bcb5315b8
// Interface Version: 2.0



namespace rpc_4dace966_a243_4450_ae3f_9b7bcb5315b8_2_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(NtApiDotNet.NtProcess p0)
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
        public NtApiDotNet.NtProcess Read_1()
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
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt64(Member8);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
            m.WriteInt32(Member20);
            m.WriteSByte(Member24);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt64();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
            Member20 = u.ReadInt32();
            Member24 = u.ReadSByte();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public int Member0;
        public int Member4;
        public long Member8;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public int Member20;
        public sbyte Member24;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, long Member8, int Member10, int Member14, int Member18, int Member1C, int Member20, sbyte Member24)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member24 = Member24;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("4dace966-a243-4450-ae3f-9b7bcb5315b8", 2, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint RmGameModeSrvRegisterProcess(NtApiDotNet.NtProcess p0, Struct_0 p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_1(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadUInt32();
        }
        public uint RmGameModeSrvUnregisterProcess(NtApiDotNet.NtProcess p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_1(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadUInt32();
        }
        public uint RmGameModeSrvDisableForRegisteredProcess(NtApiDotNet.NtProcess p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_1(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadUInt32();
        }
        public uint RmGameModeSrvReenableForRegisteredProcess(NtApiDotNet.NtProcess p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_1(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadUInt32();
        }
        public uint RmGameModeSrvGetLargestValidResourceRequest(out Struct_0 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.Read_0();
            return u.ReadUInt32();
        }
        public uint RmGameModeSrvRegisterPairedAuxiliaryProcess(NtApiDotNet.NtProcess p0, Struct_0 p1, NtApiDotNet.NtProcess p2, int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_1(p0);
            m.Write_0(p1);
            m.Write_1(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadUInt32();
        }
    }
    #endregion
}

