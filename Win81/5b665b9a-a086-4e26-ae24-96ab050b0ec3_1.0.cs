//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\das.dll
// Interface ID: 5b665b9a-a086-4e26-ae24-96ab050b0ec3
// Interface Version: 1.0



namespace rpc_5b665b9a_a086_4e26_ae24_96ab050b0ec3_1_0
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
        public void Write_3(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_4(Struct_0[] p0, long p1)
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
        public sbyte[] Read_3()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_0[] Read_4()
        {
            return ReadConformantStructArray<Struct_0>();
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
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
            m.WriteEmbeddedPointer<sbyte[], long>(Member28, new System.Action<sbyte[], long>(m.Write_3), Member24);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
            Member28 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_3), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_1 Member0;
        public int Member20;
        public int Member24;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member28;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(Struct_1 Member0, int Member20, int Member24, sbyte[] Member28)
        {
            this.Member0 = Member0;
            this.Member20 = Member20;
            this.Member24 = Member24;
            this.Member28 = Member28;
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
            m.Write_2(Member0);
            m.WriteInt32(Member14);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_2();
            Member14 = u.ReadInt32();
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public Struct_2 Member0;
        public int Member14;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(Struct_2 Member0, int Member14, string Member18)
        {
            this.Member0 = Member0;
            this.Member14 = Member14;
            this.Member18 = Member18;
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
            m.WriteGuid(Member0);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public int Member10;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(System.Guid Member0, int Member10)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("5b665b9a-a086-4e26-ae24-96ab050b0ec3", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int DasCreateAepStoreAep(string p0, int p1, Struct_0[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int DasDeleteAepStoreAep(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int DasSetAepStoreAepProperties(string p0, int p1, Struct_0[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

