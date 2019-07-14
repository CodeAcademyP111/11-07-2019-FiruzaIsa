using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugList
{
    public class Pharmacy
    {
        private static int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        private List<Drug> drugs;

        public Pharmacy(string name, string adress)
        {
            _id++;
            ID = _id;
            Name = name;
            Adress = adress;
            drugs = new List<Drug>()
            {
                new Drug {Type="Painkiller",Name="Analgin",Price=2.50},
                new Drug {Type="Painkiller",Name="Baralgin",Price=1.50},
                new Drug {Type="Infection",Name="Ciloxan",Price=10.00},
                new Drug {Type="Diabete",Name="Metformin",Price=105.00}



            };

        }

        public List<Drug> GetMedicine()
        {
            return drugs;
        }
        public void AddDrug(Drug d)
        {
            drugs.Add(d);
        }

        public void UpdateDrug(int id,string type,string name,double price)
        {
            Drug drug = PressDrug(id);
            drug.Type = type;
            drug.Name = name;
            drug.Price = price;
        }
        public Drug PressDrug(int choosen)
        {
            Drug drugID = null;
            for (int i = 0; i < drugs.Count; i++)
            {
                if (choosen == drugs[i].ID)
                {
                    drugID=drugs[i];
                }
            }
            return drugID;
        }
        public void DeleteID (int id)
        {
            for (int i = 0; i < drugs.Count; i++)
            {
                if (id == drugs[i].ID)
                {
                    drugs.RemoveAt(id);
                    return;
                }
            }
        }
    }
}
