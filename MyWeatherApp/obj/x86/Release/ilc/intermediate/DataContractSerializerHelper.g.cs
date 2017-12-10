using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 423
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                5, // array length: 5
                1058, // index: 1058, string: "city"
                1063, // index: 1063, string: "cnt"
                1067, // index: 1067, string: "cod"
                1071, // index: 1071, string: "list"
                1076, // index: 1076, string: "message"
                5, // array length: 5
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                1084, // index: 1084, string: "coord"
                1090, // index: 1090, string: "country"
                1098, // index: 1098, string: "name"
                1103, // index: 1103, string: "population"
                4, // array length: 4
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                1114, // index: 1114, string: "lat"
                1118, // index: 1118, string: "lon"
                2, // array length: 2
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                7, // array length: 7
                1122, // index: 1122, string: "clouds"
                1129, // index: 1129, string: "dt"
                1132, // index: 1132, string: "dt_txt"
                1139, // index: 1139, string: "main"
                1144, // index: 1144, string: "sys"
                1148, // index: 1148, string: "weather"
                1156, // index: 1156, string: "wind"
                7, // array length: 7
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                1, // array length: 1
                1161, // index: 1161, string: "all"
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                8, // array length: 8
                1165, // index: 1165, string: "grnd_level"
                1176, // index: 1176, string: "humidity"
                1185, // index: 1185, string: "pressure"
                1194, // index: 1194, string: "sea_level"
                1204, // index: 1204, string: "temp"
                1209, // index: 1209, string: "temp_kf"
                1217, // index: 1217, string: "temp_max"
                1226, // index: 1226, string: "temp_min"
                8, // array length: 8
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                1, // array length: 1
                1235, // index: 1235, string: "pod"
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                1239, // index: 1239, string: "description"
                1251, // index: 1251, string: "icon"
                1256, // index: 1256, string: "id"
                1139, // index: 1139, string: "main"
                4, // array length: 4
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                1259, // index: 1259, string: "deg"
                1263, // index: 1263, string: "speed"
                2, // array length: 2
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                11, // array length: 11
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                11, // array length: 11
                1269, // index: 1269, string: "base"
                1122, // index: 1122, string: "clouds"
                1067, // index: 1067, string: "cod"
                1084, // index: 1084, string: "coord"
                1129, // index: 1129, string: "dt"
                1256, // index: 1256, string: "id"
                1139, // index: 1139, string: "main"
                1098, // index: 1098, string: "name"
                1144, // index: 1144, string: "sys"
                1148, // index: 1148, string: "weather"
                1156, // index: 1156, string: "wind"
                11, // array length: 11
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                1, // array length: 1
                1161, // index: 1161, string: "all"
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                1114, // index: 1114, string: "lat"
                1118, // index: 1118, string: "lon"
                2, // array length: 2
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                7, // array length: 7
                1165, // index: 1165, string: "grnd_level"
                1176, // index: 1176, string: "humidity"
                1185, // index: 1185, string: "pressure"
                1194, // index: 1194, string: "sea_level"
                1204, // index: 1204, string: "temp"
                1217, // index: 1217, string: "temp_max"
                1226, // index: 1226, string: "temp_min"
                7, // array length: 7
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                1090, // index: 1090, string: "country"
                1076, // index: 1076, string: "message"
                1274, // index: 1274, string: "sunrise"
                1282, // index: 1282, string: "sunset"
                4, // array length: 4
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                4, // array length: 4
                1239, // index: 1239, string: "description"
                1251, // index: 1251, string: "icon"
                1256, // index: 1256, string: "id"
                1139, // index: 1139, string: "main"
                4, // array length: 4
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                2, // array length: 2
                1259, // index: 1259, string: "deg"
                1263, // index: 1263, string: "speed"
                2, // array length: 2
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                281, // index: 281, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                5, // array length: 5
                1058, // index: 1058, string: "city"
                1063, // index: 1063, string: "cnt"
                1067, // index: 1067, string: "cod"
                1071, // index: 1071, string: "list"
                1076, // index: 1076, string: "message"
                5, // array length: 5
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                4, // array length: 4
                1084, // index: 1084, string: "coord"
                1090, // index: 1090, string: "country"
                1256, // index: 1256, string: "id"
                1098, // index: 1098, string: "name"
                4, // array length: 4
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                2, // array length: 2
                1114, // index: 1114, string: "lat"
                1118, // index: 1118, string: "lon"
                2, // array length: 2
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                7, // array length: 7
                1122, // index: 1122, string: "clouds"
                1129, // index: 1129, string: "dt"
                1132, // index: 1132, string: "dt_txt"
                1139, // index: 1139, string: "main"
                1144, // index: 1144, string: "sys"
                1148, // index: 1148, string: "weather"
                1156, // index: 1156, string: "wind"
                7, // array length: 7
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                1, // array length: 1
                1161, // index: 1161, string: "all"
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                8, // array length: 8
                1165, // index: 1165, string: "grnd_level"
                1176, // index: 1176, string: "humidity"
                1185, // index: 1185, string: "pressure"
                1194, // index: 1194, string: "sea_level"
                1204, // index: 1204, string: "temp"
                1209, // index: 1209, string: "temp_kf"
                1217, // index: 1217, string: "temp_max"
                1226, // index: 1226, string: "temp_min"
                8, // array length: 8
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                1, // array length: 1
                1235, // index: 1235, string: "pod"
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                4, // array length: 4
                1239, // index: 1239, string: "description"
                1251, // index: 1251, string: "icon"
                1256, // index: 1256, string: "id"
                1139, // index: 1139, string: "main"
                4, // array length: 4
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                2, // array length: 2
                1259, // index: 1259, string: "deg"
                1263, // index: 1263, string: "speed"
                2, // array length: 2
                653, // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
                653  // index: 653, string: "http://schemas.datacontract.org/2004/07/MyWeatherApp.Models"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=68
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+RootObject1, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                "oken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+City, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                "ull")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0," +
                                " Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=" +
                                "b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0" +
                                ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.RootObject, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=ne" +
                                "utral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                "50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+RootObject2, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                "ken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+City, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, " +
                                "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                "03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                "ull")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                "")),
                    TableIndex = 353, // 0x161
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0." +
                                "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                "n=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                    TableIndex = 369, // 0x171
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 385, // 0x181
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=25
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // FutureWeather.RootObject1
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 255, // FutureWeather.RootObject1
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 255, // FutureWeather.RootObject1
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+RootObject1, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+RootObject1, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyT" +
                                    "oken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 7,
                    MemberNamesListIndex = 9,
                    MemberNamespacesListIndex = 15,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 348, // FutureWeather.City
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 348, // FutureWeather.City
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 348, // FutureWeather.City
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+City, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+City, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 21,
                    ContractNamespacesListIndex = 26,
                    MemberNamesListIndex = 28,
                    MemberNamespacesListIndex = 33,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 367, // FutureWeather.Coord
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 367, // FutureWeather.Coord
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 367, // FutureWeather.Coord
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 38,
                    ContractNamespacesListIndex = 41,
                    MemberNamesListIndex = 43,
                    MemberNamespacesListIndex = 46,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 413, // FutureWeather.List
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 413, // FutureWeather.List
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 413, // FutureWeather.List
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 49,
                    ContractNamespacesListIndex = 57,
                    MemberNamesListIndex = 59,
                    MemberNamespacesListIndex = 67,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 432, // FutureWeather.Clouds
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 432, // FutureWeather.Clouds
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 432, // FutureWeather.Clouds
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 75,
                    ContractNamespacesListIndex = 77,
                    MemberNamesListIndex = 79,
                    MemberNamespacesListIndex = 81,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 453, // FutureWeather.Main
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 453, // FutureWeather.Main
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 453, // FutureWeather.Main
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 83,
                    ContractNamespacesListIndex = 92,
                    MemberNamesListIndex = 94,
                    MemberNamespacesListIndex = 103,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 472, // FutureWeather.Sys
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 472, // FutureWeather.Sys
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 472, // FutureWeather.Sys
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 112,
                    ContractNamespacesListIndex = 114,
                    MemberNamesListIndex = 116,
                    MemberNamespacesListIndex = 118,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 519, // FutureWeather.Weather
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 519, // FutureWeather.Weather
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 519, // FutureWeather.Weather
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                    "=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 120,
                    ContractNamespacesListIndex = 125,
                    MemberNamesListIndex = 127,
                    MemberNamespacesListIndex = 132,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 541, // FutureWeather.Wind
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 541, // FutureWeather.Wind
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 541, // FutureWeather.Wind
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 137,
                    ContractNamespacesListIndex = 140,
                    MemberNamesListIndex = 142,
                    MemberNamespacesListIndex = 145,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 560, // RootObject
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 560, // RootObject
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 560, // RootObject
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.RootObject, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.RootObject, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 148,
                    ContractNamespacesListIndex = 160,
                    MemberNamesListIndex = 162,
                    MemberNamespacesListIndex = 174,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 571, // Clouds
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 571, // Clouds
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 571, // Clouds
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 186,
                    ContractNamespacesListIndex = 188,
                    MemberNamesListIndex = 190,
                    MemberNamespacesListIndex = 192,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 578, // Coord
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 578, // Coord
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 578, // Coord
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 194,
                    ContractNamespacesListIndex = 197,
                    MemberNamesListIndex = 199,
                    MemberNamespacesListIndex = 202,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 584, // Main
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 584, // Main
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 584, // Main
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 205,
                    ContractNamespacesListIndex = 213,
                    MemberNamesListIndex = 215,
                    MemberNamespacesListIndex = 223,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 589, // Sys
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 589, // Sys
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 589, // Sys
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 231,
                    ContractNamespacesListIndex = 236,
                    MemberNamesListIndex = 238,
                    MemberNamespacesListIndex = 243,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 608, // Weather
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 608, // Weather
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 608, // Weather
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 248,
                    ContractNamespacesListIndex = 253,
                    MemberNamesListIndex = 255,
                    MemberNamespacesListIndex = 260,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 616, // Wind
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 616, // Wind
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 616, // Wind
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 265,
                    ContractNamespacesListIndex = 268,
                    MemberNamesListIndex = 270,
                    MemberNamespacesListIndex = 273,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 621, // FutureWeatherByCity.RootObject2
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 621, // FutureWeatherByCity.RootObject2
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 621, // FutureWeatherByCity.RootObject2
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+RootObject2, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+RootObject2, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 276,
                    ContractNamespacesListIndex = 282,
                    MemberNamesListIndex = 284,
                    MemberNamespacesListIndex = 290,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 713, // FutureWeatherByCity.City
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 713, // FutureWeatherByCity.City
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 713, // FutureWeatherByCity.City
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+City, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+City, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 296,
                    ContractNamespacesListIndex = 301,
                    MemberNamesListIndex = 303,
                    MemberNamespacesListIndex = 308,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 738, // FutureWeatherByCity.Coord
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 738, // FutureWeatherByCity.Coord
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 738, // FutureWeatherByCity.Coord
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Coord, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                    "ll")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 313,
                    ContractNamespacesListIndex = 316,
                    MemberNamesListIndex = 318,
                    MemberNamespacesListIndex = 321,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 796, // FutureWeatherByCity.List
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 796, // FutureWeatherByCity.List
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 796, // FutureWeatherByCity.List
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 324,
                    ContractNamespacesListIndex = 332,
                    MemberNamesListIndex = 334,
                    MemberNamespacesListIndex = 342,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 821, // FutureWeatherByCity.Clouds
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 821, // FutureWeatherByCity.Clouds
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 821, // FutureWeatherByCity.Clouds
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Clouds, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
                                    "ull")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 350,
                    ContractNamespacesListIndex = 352,
                    MemberNamesListIndex = 354,
                    MemberNamespacesListIndex = 356,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 848, // FutureWeatherByCity.Main
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 848, // FutureWeatherByCity.Main
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 848, // FutureWeatherByCity.Main
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Main, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 358,
                    ContractNamespacesListIndex = 367,
                    MemberNamesListIndex = 369,
                    MemberNamespacesListIndex = 378,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 873, // FutureWeatherByCity.Sys
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 873, // FutureWeatherByCity.Sys
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 873, // FutureWeatherByCity.Sys
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Sys, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" +
                                    "")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 387,
                    ContractNamespacesListIndex = 389,
                    MemberNamesListIndex = 391,
                    MemberNamespacesListIndex = 393,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 932, // FutureWeatherByCity.Weather
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 932, // FutureWeatherByCity.Weather
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 932, // FutureWeatherByCity.Weather
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 395,
                    ContractNamespacesListIndex = 400,
                    MemberNamesListIndex = 402,
                    MemberNamespacesListIndex = 407,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 960, // FutureWeatherByCity.Wind
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 960, // FutureWeatherByCity.Wind
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 960, // FutureWeatherByCity.Wind
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Wind, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 412,
                    ContractNamespacesListIndex = 415,
                    MemberNamesListIndex = 417,
                    MemberNamespacesListIndex = 420,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=6
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 387, // ArrayOfFutureWeather.List
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 387, // ArrayOfFutureWeather.List
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 387, // ArrayOfFutureWeather.List
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 413, // FutureWeather.List
                    KeyNameIndex = -1,
                    ItemNameIndex = 413, // FutureWeather.List
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 490, // ArrayOfFutureWeather.Weather
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 490, // ArrayOfFutureWeather.Weather
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 490, // ArrayOfFutureWeather.Weather
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0" +
                                    ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0" +
                                    ".0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 519, // FutureWeather.Weather
                    KeyNameIndex = -1,
                    ItemNameIndex = 519, // FutureWeather.Weather
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.FutureWeather+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 593, // ArrayOfWeather
                        NamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        StableNameIndex = 593, // ArrayOfWeather
                        StableNameNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        TopLevelElementNameIndex = 593, // ArrayOfWeather
                        TopLevelElementNamespaceIndex = 281, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Assets.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 608, // Weather
                    KeyNameIndex = -1,
                    ItemNameIndex = 608, // Weather
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Assets.Models.Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 764, // ArrayOfFutureWeatherByCity.List
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 764, // ArrayOfFutureWeatherByCity.List
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 764, // ArrayOfFutureWeatherByCity.List
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, " +
                                    "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, " +
                                    "Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 796, // FutureWeatherByCity.List
                    KeyNameIndex = -1,
                    ItemNameIndex = 796, // FutureWeatherByCity.List
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+List, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 897, // ArrayOfFutureWeatherByCity.Weather
                        NamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        StableNameIndex = 897, // ArrayOfFutureWeatherByCity.Weather
                        StableNameNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        TopLevelElementNameIndex = 897, // ArrayOfFutureWeatherByCity.Weather
                        TopLevelElementNamespaceIndex = 653, // http://schemas.datacontract.org/2004/07/MyWeatherApp.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    CollectionItemNameIndex = 932, // FutureWeatherByCity.Weather
                    KeyNameIndex = -1,
                    ItemNameIndex = 932, // FutureWeatherByCity.Weather
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MyWeatherApp.Models.FutureWeatherByCity+Weather, MyWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 985, // ArrayOfanyType
                        NamespaceIndex = 1000, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 985, // ArrayOfanyType
                        StableNameNamespaceIndex = 1000, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 985, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 1000, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=31
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type3.WriteFutureWeather_RootObject1ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type2.ReadFutureWeather_RootObject1FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type7.WriteFutureWeather_CityToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type6.ReadFutureWeather_CityFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type11.WriteFutureWeather_CoordToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type10.ReadFutureWeather_CoordFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type16.WriteArrayOfFutureWeather_ListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type15.ReadArrayOfFutureWeather_ListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type17.ReadArrayOfFutureWeather_ListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type21.WriteFutureWeather_ListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type20.ReadFutureWeather_ListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 42,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type25.WriteFutureWeather_CloudsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type24.ReadFutureWeather_CloudsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type29.WriteFutureWeather_MainToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type28.ReadFutureWeather_MainFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type33.WriteFutureWeather_SysToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type32.ReadFutureWeather_SysFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type38.WriteArrayOfFutureWeather_WeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type37.ReadArrayOfFutureWeather_WeatherFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type39.ReadArrayOfFutureWeather_WeatherFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type43.WriteFutureWeather_WeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type42.ReadFutureWeather_WeatherFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type47.WriteFutureWeather_WindToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type46.ReadFutureWeather_WindFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type51.WriteRootObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type50.ReadRootObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type55.WriteCloudsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type54.ReadCloudsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type59.WriteCoordToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type58.ReadCoordFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 51,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type63.WriteMainToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type62.ReadMainFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type67.WriteSysToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type66.ReadSysFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type72.WriteArrayOfWeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type71.ReadArrayOfWeatherFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type73.ReadArrayOfWeatherFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type77.WriteWeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type76.ReadWeatherFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type81.WriteWindToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type80.ReadWindFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type85.WriteFutureWeatherByCity_RootObject2ToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type84.ReadFutureWeatherByCity_RootObject2FromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type89.WriteFutureWeatherByCity_CityToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type88.ReadFutureWeatherByCity_CityFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type93.WriteFutureWeatherByCity_CoordToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type92.ReadFutureWeatherByCity_CoordFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type98.WriteArrayOfFutureWeatherByCity_ListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type97.ReadArrayOfFutureWeatherByCity_ListFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type99.ReadArrayOfFutureWeatherByCity_ListFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type103.WriteFutureWeatherByCity_ListToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type102.ReadFutureWeatherByCity_ListFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 61,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type107.WriteFutureWeatherByCity_CloudsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type106.ReadFutureWeatherByCity_CloudsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type111.WriteFutureWeatherByCity_MainToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type110.ReadFutureWeatherByCity_MainFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 63,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type115.WriteFutureWeatherByCity_SysToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type114.ReadFutureWeatherByCity_SysFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type120.WriteArrayOfFutureWeatherByCity_WeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type119.ReadArrayOfFutureWeatherByCity_WeatherFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type121.ReadArrayOfFutureWeatherByCity_WeatherFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 65,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type125.WriteFutureWeatherByCity_WeatherToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type124.ReadFutureWeatherByCity_WeatherFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type129.WriteFutureWeatherByCity_WindToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type128.ReadFutureWeatherByCity_WindFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 67,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type134.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type133.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type135.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','.','R',
            'o','o','t','O','b','j','e','c','t','1','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a',
            'c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','y','W','e','a','t','h','e','r',
            'A','p','p','.','A','s','s','e','t','s','.','M','o','d','e','l','s','\0','F','u','t','u','r','e','W','e','a','t','h','e',
            'r','.','C','i','t','y','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','.','C','o','o','r','d','\0','A','r','r',
            'a','y','O','f','F','u','t','u','r','e','W','e','a','t','h','e','r','.','L','i','s','t','\0','F','u','t','u','r','e','W',
            'e','a','t','h','e','r','.','L','i','s','t','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','.','C','l','o','u',
            'd','s','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','.','M','a','i','n','\0','F','u','t','u','r','e','W','e',
            'a','t','h','e','r','.','S','y','s','\0','A','r','r','a','y','O','f','F','u','t','u','r','e','W','e','a','t','h','e','r',
            '.','W','e','a','t','h','e','r','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','.','W','e','a','t','h','e','r',
            '\0','F','u','t','u','r','e','W','e','a','t','h','e','r','.','W','i','n','d','\0','R','o','o','t','O','b','j','e','c','t',
            '\0','C','l','o','u','d','s','\0','C','o','o','r','d','\0','M','a','i','n','\0','S','y','s','\0','A','r','r','a','y','O','f',
            'W','e','a','t','h','e','r','\0','W','e','a','t','h','e','r','\0','W','i','n','d','\0','F','u','t','u','r','e','W','e','a',
            't','h','e','r','B','y','C','i','t','y','.','R','o','o','t','O','b','j','e','c','t','2','\0','h','t','t','p',':','/','/',
            's','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/',
            '0','7','/','M','y','W','e','a','t','h','e','r','A','p','p','.','M','o','d','e','l','s','\0','F','u','t','u','r','e','W',
            'e','a','t','h','e','r','B','y','C','i','t','y','.','C','i','t','y','\0','F','u','t','u','r','e','W','e','a','t','h','e',
            'r','B','y','C','i','t','y','.','C','o','o','r','d','\0','A','r','r','a','y','O','f','F','u','t','u','r','e','W','e','a',
            't','h','e','r','B','y','C','i','t','y','.','L','i','s','t','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','B',
            'y','C','i','t','y','.','L','i','s','t','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','B','y','C','i','t','y',
            '.','C','l','o','u','d','s','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','B','y','C','i','t','y','.','M','a',
            'i','n','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','B','y','C','i','t','y','.','S','y','s','\0','A','r','r',
            'a','y','O','f','F','u','t','u','r','e','W','e','a','t','h','e','r','B','y','C','i','t','y','.','W','e','a','t','h','e',
            'r','\0','F','u','t','u','r','e','W','e','a','t','h','e','r','B','y','C','i','t','y','.','W','e','a','t','h','e','r','\0',
            'F','u','t','u','r','e','W','e','a','t','h','e','r','B','y','C','i','t','y','.','W','i','n','d','\0','A','r','r','a','y',
            'O','f','a','n','y','T','y','p','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o',
            's','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n',
            '/','A','r','r','a','y','s','\0','c','i','t','y','\0','c','n','t','\0','c','o','d','\0','l','i','s','t','\0','m','e','s','s',
            'a','g','e','\0','c','o','o','r','d','\0','c','o','u','n','t','r','y','\0','n','a','m','e','\0','p','o','p','u','l','a','t',
            'i','o','n','\0','l','a','t','\0','l','o','n','\0','c','l','o','u','d','s','\0','d','t','\0','d','t','_','t','x','t','\0','m',
            'a','i','n','\0','s','y','s','\0','w','e','a','t','h','e','r','\0','w','i','n','d','\0','a','l','l','\0','g','r','n','d','_',
            'l','e','v','e','l','\0','h','u','m','i','d','i','t','y','\0','p','r','e','s','s','u','r','e','\0','s','e','a','_','l','e',
            'v','e','l','\0','t','e','m','p','\0','t','e','m','p','_','k','f','\0','t','e','m','p','_','m','a','x','\0','t','e','m','p',
            '_','m','i','n','\0','p','o','d','\0','d','e','s','c','r','i','p','t','i','o','n','\0','i','c','o','n','\0','i','d','\0','d',
            'e','g','\0','s','p','e','e','d','\0','b','a','s','e','\0','s','u','n','r','i','s','e','\0','s','u','n','s','e','t','\0'};
    }
}
