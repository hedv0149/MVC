using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForExam.Models
{
    public class GiftREPO
    {
        object myLock = new object();
        private static List<Gift> giftList = new List<Gift>();
        public List<Gift> GetAll()
        {
            lock (myLock)
            {
                return giftList.ToList();
            }
        }
        public void AddGift(GiftModels gi)
        {
            lock (myLock)
            {
                Gift gift = new Gift() { Number = gi.Number, Title = gi.Title, Description = gi.Description, Boy = gi.Boy, Girl = gi.Girl, Date = gi.Date };
                giftList.Add(gift);
            }
        }
        public List<Gift> GetGirlGiftList()
        {
            lock (myLock)
            {
                List<Gift> girlGiftList = new List<Gift>();
                foreach(Gift gift in giftList)
                {
                    if(gift.Girl == true)
                    {
                        girlGiftList.Add(gift);
                    }
                }
                return girlGiftList;
            }
        }
    }
}
