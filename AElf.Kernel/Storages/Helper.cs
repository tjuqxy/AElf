﻿using System;
using System.Linq;
using Google.Protobuf;
using static AElf.Kernel.Storages.Types;

namespace AElf.Kernel.Storages
{
    public static class Helper
    {
        public static string GetKeyString(this Hash hash, uint type)
        {
            return new Key
            {
                Type = type,
                Value = ByteString.CopyFrom(hash.GetHashBytes()),
                HashType = (uint) hash.HashType
            }.ToByteArray().ToHex();
        }
    }
    
    // ReSharper disable UnusedMember.Global
    public enum Types
    {
        UInt64Value = 0,
        Hash,
        BlockBody,
        BlockHeader,
        Chain,
        Change,
        SmartContractRegistration,
        TransactionResult,
        Transaction,
        FunctionMetadata,
        SerializedCallGraph,
        SideChain,
        WorldState
    }
}