
namespace STBaseSys
{
    public class DataStore
    {
        protected  EDataStoreTag m_Tag = EDataStoreTag.ENone;
        public  EDataStoreTag Tag
        {
            get { return m_Tag; }
            set { m_Tag = value; }
        }
        public DataStore()
        {

        }
        public DataStore(EDataStoreTag tag)
        {
            m_Tag = tag;
        }
 
        public virtual void InitializeDataStore()
        {

        }

        public virtual void Reset()
        {

        }
    }
}
