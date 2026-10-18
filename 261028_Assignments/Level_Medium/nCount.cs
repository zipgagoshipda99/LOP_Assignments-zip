using System.Reflection.Metadata.Ecma335;

namespace Level_Medium
{
    public class nCount{
        
        Random random = new Random();
        private int ncount = 0;
        public void SetCount()
        {
            bool isParsed = int.TryParse(Console.ReadLine() , out ncount);
            if(!isParsed) return;
        }
        public int GetCount()
        {
            return ncount;
        }

        
    }
    
}