//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\IPHLPAPI.DLL
// Interface ID: 6f201a55-a24d-495f-aac9-2f4fce34df99
// Interface Version: 1.0



namespace rpc_6f201a55_a24d_495f_aac9_2f4fce34df99_1_0
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
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_4(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_5(byte[] p0, long p1)
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_4()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_5()
        {
            return ReadConformantArray<byte>();
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
            m.WriteInt16(Member0);
            m.WriteEmbeddedPointer<byte[], long>(Member8, new System.Action<byte[], long>(m.Write_2), 16);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member8 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_2), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member8;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member8 = new byte[0];
            return ret;
        }
        public Struct_0(short Member0, byte[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
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
            m.WriteEmbeddedPointer<Struct_1>(Member0, new System.Action<Struct_1>(m.Write_1));
            m.WriteInt32(Member8);
            m.WriteEmbeddedPointer<byte[], long>(Member10, new System.Action<byte[], long>(m.Write_3), Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            Member8 = u.ReadInt32();
            Member10 = u.ReadEmbeddedPointer<byte[]>(new System.Func<byte[]>(u.Read_3), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_1> Member0;
        public int Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<byte[]> Member10;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(System.Nullable<Struct_1> Member0, int Member8, byte[] Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("6f201a55-a24d-495f-aac9-2f4fce34df99", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public int SpiEstablishSession(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        // async
        public void SpiTerminateSession(int p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
        }
        // async
        public int SpiTransitionFromDormantToActive(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            return u.ReadInt32();
        }
        // async
        public int SpiTransitionFromActiveToDormant(int p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        // async
        public int SpiAddTransportId(int p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        // async
        public int SpiRemoveTransportId(int p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        // async
        public int SpiIsRemoteTransportIdReachable(int p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        // async
        public int SpiSendData(int p0, Struct_0 p1, Struct_0 p2, long p3, Struct_1 p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            m.Write_0(p2);
            m.WriteInt64(p3);
            m.Write_1(p4);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        // async
        public int SpiReceiveData(int p0, ref Struct_0 p1, ref Struct_0 p2, out System.Nullable<Struct_1> p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            m.Write_0(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            p1 = u.Read_0();
            p2 = u.Read_0();
            p3 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_1), false);
            return u.ReadInt32();
        }
        // async
        public int SpiReceiveAuthorizeCallback(int p0, ref Struct_0 p1, ref Struct_0 p2, int p3, ref int p4, ref byte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            m.Write_0(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.Write_4(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"), p3);
            _Unmarshal_Helper u = SendReceive(9, m);
            p1 = u.Read_0();
            p2 = u.Read_0();
            p4 = u.ReadInt32();
            p5 = u.Read_4();
            return u.ReadInt32();
        }
        // async
        public int SpiReceiveAuthorizeCallbackComplete(int p0, Struct_0 p1, int p2, byte[] p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.Write_5(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
    }
    #endregion
}
