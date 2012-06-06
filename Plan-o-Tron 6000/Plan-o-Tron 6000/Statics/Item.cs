using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plan_o_Tron_6000.Statics
{
    

    // alle Objekte werden aus dieser Klasse erzeugt
    public class Item
    {
        protected ItemId id;

        public Item(ItemId id)
        {
            this.id = id;
            this.Parts = null;
        }

        public Item(ItemId id, List<Part> list)
            : this(id)
        {
            this.Parts = list;
        }


        public List<Part> Parts { get; set; }

        public int Id
        {
            get { return (int)this.id; }
        }

        public string Name
        { 
            get 
            { 
                return this.id.ToString(); 
            } 
        }

        // kaufteil?
        public bool BoughtItem
        {
            get
            {
                return this.Parts == null;
            }
        }

        public List<Part> GetAllParts()
        {
            List<Part> result = new List<Part>();

            // für alle Teile die nicht gebaut werden
            if (this.BoughtItem)
            {
                result.Add(new Part(1, this));
                return result;
            }

            foreach (Part it in this.Parts)
            {
                if (it.PartItem == null)
                {
                    
                    // TODO:Addition durch alle Teile
                    //if(result.Find(it)
                    result.Add(it);
                }
            }

            return result;
        }


        public String GetFlatParts
        {
            get
            {
            String result = "";

            //alle Teile die nicht gebaut werden
            if (this.Parts == null)
            {
                return result;
            }

            foreach (Part it in this.Parts)
            {
                result += it.ToString() + ", ";
            }

            return result;
            }
        }

        public override string ToString()
        {
            return this.id.ToString();
        }
    }
}
