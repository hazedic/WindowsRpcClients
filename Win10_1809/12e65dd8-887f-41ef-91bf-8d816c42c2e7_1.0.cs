//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\winlogon.exe
// Interface ID: 12e65dd8-887f-41ef-91bf-8d816c42c2e7
// Interface Version: 1.0



namespace rpc_12e65dd8_887f_41ef_91bf_8d816c42c2e7_1_0
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
        public void Write_3(sbyte[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<sbyte>(p0, p1, p2);
        }
        public void Write_4(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_5(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_6(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_7(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_8(sbyte[] p0, long p1)
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
            return ReadConformantVaryingArray<sbyte>();
        }
        public sbyte[] Read_4()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_5()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_6()
        {
            return ReadConformantArray<sbyte>();
        }
        public char[] Read_7()
        {
            return ReadConformantArray<char>();
        }
        public sbyte[] Read_8()
        {
            return ReadConformantArray<sbyte>();
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
            m.WriteEnum16(Member0);
            m.WriteEmbeddedPointer<Struct_1>(Member8, new System.Action<Struct_1>(m.Write_1));
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member28, new System.Action<string>(m.WriteTerminatedString));
            m.WriteUInt3264(Member30);
            m.WriteInt16(Member38);
            m.WriteInt16(Member3A);
            m.WriteEnum16(Member3C);
            m.WriteUInt3264(Member40);
            m.WriteUInt3264(Member48);
            m.WriteInt32(Member50);
            m.WriteEmbeddedPointer<sbyte[], long, long>(Member58, new System.Action<sbyte[], long, long>(m.Write_3), Member50, Member50);
            m.WriteInt32(Member60);
            m.WriteInt32(Member64);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.ReadEmbeddedPointer<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member30 = u.ReadUInt3264();
            Member38 = u.ReadInt16();
            Member3A = u.ReadInt16();
            Member3C = u.ReadEnum16();
            Member40 = u.ReadUInt3264();
            Member48 = u.ReadUInt3264();
            Member50 = u.ReadInt32();
            Member58 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_3), false);
            Member60 = u.ReadInt32();
            Member64 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_1> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member28;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member30;
        public short Member38;
        public short Member3A;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member3C;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member40;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member48;
        public int Member50;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member58;
        public int Member60;
        public int Member64;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(
                    NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, 
                    System.Nullable<Struct_1> Member8, 
                    string Member10, 
                    string Member18, 
                    string Member20, 
                    string Member28, 
                    NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member30, 
                    short Member38, 
                    short Member3A, 
                    NtApiDotNet.Ndr.Marshal.NdrEnum16 Member3C, 
                    NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member40, 
                    NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member48, 
                    int Member50, 
                    sbyte[] Member58, 
                    int Member60, 
                    int Member64)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member3A = Member3A;
            this.Member3C = Member3C;
            this.Member40 = Member40;
            this.Member48 = Member48;
            this.Member50 = Member50;
            this.Member58 = Member58;
            this.Member60 = Member60;
            this.Member64 = Member64;
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
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0)
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
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(Member10);
            m.WriteEmbeddedPointer<string>(Member18, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member20, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<sbyte[], long>(Member28, new System.Action<sbyte[], long>(m.Write_4), Member30);
            m.WriteInt32(Member30);
            m.WriteEmbeddedPointer<System.Guid>(Member38, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteEmbeddedPointer<string>(Member40, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member48, new System.Action<string>(m.WriteTerminatedString));
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
            Member18 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member20 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member28 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_4), false);
            Member30 = u.ReadInt32();
            Member38 = u.ReadEmbeddedPointer<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            Member40 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member48 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member28;
        public int Member30;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<System.Guid> Member38;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member40;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member48;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(string Member0, string Member8, int Member10, string Member18, string Member20, sbyte[] Member28, int Member30, System.Nullable<System.Guid> Member38, string Member40, string Member48)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member40 = Member40;
            this.Member48 = Member48;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("12e65dd8-887f-41ef-91bf-8d816c42c2e7", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public int WlSecureDesktoprPromptingRequest(int p0, Struct_0 p1, Struct_2 p2, int p3, int p4, sbyte[] p5, int p6, int p7, int p8, out sbyte[] p9, out int p10, out int p11, out int p12, ref int p13)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            m.Write_2(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteReferent(p5, new System.Action<sbyte[], long>(m.Write_5), p6);
            m.WriteInt32(p6);
            m.WriteInt32(p7);
            m.WriteInt32(p8);
            m.WriteInt32(p13);
            _Unmarshal_Helper u = SendReceive(0, m);
            p9 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_6), false);
            p10 = u.ReadInt32();
            p11 = u.ReadInt32();
            p12 = u.ReadInt32();
            p13 = u.ReadInt32();
            return u.ReadInt32();
        }
        // async
        public int WlSecureDesktoprConfirmationRequest(string p0, int p1, int p2, int p3, out char[] p4, out int p5, out sbyte[] p6, out int p7)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(1, m);
            p4 = u.ReadReferent<char[]>(new System.Func<char[]>(u.Read_7), false);
            p5 = u.ReadInt32();
            p6 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_8), false);
            p7 = u.ReadInt32();
            return u.ReadInt32();
        }
        // async
        public int WlSecureDesktoprCredmanBackupRequest(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        // async
        public int WlSecureDesktoprCredmanRestoreRequest(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int WlSecureDesktoprSimulateSAS()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

