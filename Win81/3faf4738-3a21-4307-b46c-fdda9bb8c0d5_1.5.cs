//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\audiosrv.dll
// Interface ID: 3faf4738-3a21-4307-b46c-fdda9bb8c0d5
// Interface Version: 1.5



namespace rpc_3faf4738_3a21_4307_b46c_fdda9bb8c0d5_1_5
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(byte[] p0, long p1)
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
        public byte[] Read_0()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("3faf4738-3a21-4307-b46c-fdda9bb8c0d5", 1, 5)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_winmmGetPnpInfo(out int p0, out byte[] p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadInt32();
            p1 = u.ReadReferent<byte[]>(new System.Func<byte[]>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int s_mmeNotifyDeviceStateChanged(string p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int s_mmeNotifyDeviceAdded(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        public int s_mmeNotifyDeviceRemoved(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int s_mmeNotifyDefaultDeviceChanged(int p0, int p1, string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int s_tsSessionGetAudioProtocol(int p0, out int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_tsRegisterAudioProtocolNotification(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_tsUnregisterAudioProtocolNotification(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(7, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_sndevtResolveSoundAlias(string p0, string p1, int p2, out NtApiDotNet.Ndr.Marshal.NdrInt3264 p3, ref string p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p2);
            m.WriteReferent(p4, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(8, m);
            p3 = u.ReadInt3264();
            p4 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            return u.ReadInt32();
        }
        public int s_pbmRegisterPlaybackManagerNotifications(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int s_pbmUnregisterPlaybackManagerNotifications(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int s_pbmGetSoundLevel(out NtApiDotNet.Ndr.Marshal.NdrEnum16 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(11, m);
            p0 = u.ReadEnum16();
            return u.ReadInt32();
        }
        public int s_pbmUpdateTrackName(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int s_pbmUpdateArtistName(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int s_pbmUpdateTrackState(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(14, m);
            return u.ReadInt32();
        }
        public int s_ccCreateHandsfreeHidFileFromAudioId(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_pbmUpdateAlbumArt(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int s_pbmRegisterAppClosureNotification()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(17, m);
            return u.ReadInt32();
        }
        public int s_pbmUnregisterAppClosureNotification()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int s_pbmPlayToStreamStateChanged(NtApiDotNet.Ndr.Marshal.NdrEnum16 p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteEnum16(p0);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int s_pbmIsPlaying(out int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(20, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_afxOpenAudioEffectsWatcher(string p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, int p2, out long p3, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteEnum16(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(21, m);
            p3 = u.ReadInt64();
            p4 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public void s_afxCloseAudioEffectsWatcher(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(22, m);
            p0 = u.ReadContextHandle();
        }
        public int s_midiOpenPort(string p0, out NtApiDotNet.Ndr.Marshal.NdrUInt3264 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(23, m);
            p1 = u.ReadUInt3264();
            return u.ReadInt32();
        }
    }
    #endregion
}

