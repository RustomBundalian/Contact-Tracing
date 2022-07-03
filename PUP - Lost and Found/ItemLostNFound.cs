using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace PUP___Lost_and_Found
{
     public class ItemLostNFound
    {
       public string Fullname { get;set; }

        public string Contact { get; set; }

        public string ItemLost { get; set; }

        public DateTime DateLost { get; set; }

        public string PlaceLost { get; set; }

        public string Reward { get; set; }
    }

    public class ItemProcess
    {
        const string filename = @"C:\Users\Tom\source\repos\PUP Lost and Found\PUP Lost and Found\LostnFound.xml";
        public List<ItemLostNFound> getListItem()
        {
            List<ItemLostNFound> lst = null;

            FileStream fs = null;

            try 
            {
                fs = new FileStream(filename,FileMode.Open);
                XmlSerializer ser = new XmlSerializer(typeof(List<ItemLostNFound>));
                lst = (List<ItemLostNFound>)ser.Deserialize(fs);
            }
            catch(Exception)
            {
               
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return lst;
        }

        private bool SaveItem(ItemLostNFound item)
        {
            bool result = false;
            FileStream fs = null;

            try 
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<ItemLostNFound>));
                List<ItemLostNFound> lst = this.getListItem();
                if (lst == null)
                {
                    lst = new List<ItemLostNFound>();
                }
                lst.Add(item);
                fs = new FileStream(filename, FileMode.OpenOrCreate);
                ser.Serialize(fs,lst);
                result = true;
            } 
            catch(Exception)
            {
         
            }
            finally
            {
                if(fs!=null)
                {
                    fs.Close();
                }
            }

            return result;   
         
        }

        public bool SubmitItem(string fullname, string contact, string itemlost, DateTime dateLost, string placelost, string reward)
        {
            bool result = false;
            try
            {
                ItemLostNFound item = new ItemLostNFound();
                item.Fullname = fullname;
                item.Contact = contact;
                item.ItemLost = itemlost;
                item.DateLost = dateLost;
                item.PlaceLost = placelost;
                item.Reward = reward;

                result = this.SaveItem(item);
            }
            catch(Exception)
            {
             
            }
            return result;
        }
    }
}
