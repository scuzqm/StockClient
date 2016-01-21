using System;
using System.Collections.Generic;

namespace STBaseSys
{
    public enum EDataStoreTag
    {
        ENone,
        ERealTimeData,   //实时盘口数据
    }

    public class DataStoreManager
    {
        public static DataStoreManager instance = new DataStoreManager();
        private Dictionary<EDataStoreTag, DataStore> GlobalDataStores = new Dictionary<EDataStoreTag, DataStore>();
        private Dictionary<string, int> DataStoreTypeTagDict = new Dictionary<string, int>();
        public T FindOrBindDataStore<T>() where T : DataStore
        {
            System.Type type = typeof(T);
            string typeName = type.FullName;
            if(DataStoreTypeTagDict.ContainsKey(typeName))
            {
                return FindDataStore(typeName) as T;
            }
            else
            {
                return BindDataStore(type) as T;
            }
            
        }

        private DataStore FindDataStore(string typeNameInDic)
        {
            EDataStoreTag tag = (EDataStoreTag)DataStoreTypeTagDict[typeNameInDic];
            if(GlobalDataStores.ContainsKey(tag))
            {
                return GlobalDataStores[tag];
            }
            else
            {
                DataStoreTypeTagDict.Remove(typeNameInDic);
            }
            return null;

        }

        private DataStore BindDataStore(Type type)
        {
            DataStore DataResult = System.Activator.CreateInstance(type) as DataStore;
            if (DataResult != null)
            {
                DataResult.InitializeDataStore();
            }
            DataStoreTypeTagDict.Add(type.FullName, (int)DataResult.Tag);
            GlobalDataStores.Add(DataResult.Tag, DataResult);
            return DataResult;      
        }

        public void Reset()
        {
            IEnumerator<DataStore> enumerator = GlobalDataStores.Values.GetEnumerator();
            while (enumerator.MoveNext())
            {
                DataStore ds = enumerator.Current;
                if (ds != null)
                {
                    ds.Reset();
                }
            }
        }
    }
}
