using System.Data;


namespace MagicCardShare.Klassen
{
    public class Faehigkeit : TableSQL
    {
        
        public string Bezeichnung { get; private set; }
        public string Auswirkung { get; private set; }


        public Faehigkeit(int faehigkeitId, string bezeichnung, string auswirkung):base(faehigkeitId)
        {
            
            Bezeichnung = bezeichnung;
            Auswirkung = auswirkung;
        }

        public static List<Faehigkeit> ShowAllFaehigkeiten()
        {
            DataTable abilityTags = DataBaseInterakt.SelectFrom("Faehigkeit", "*");

            List<Faehigkeit> result = new List<Faehigkeit>();

            if (abilityTags != null)
            {
                
                foreach (DataRow row in abilityTags.Rows)
                {
                    Faehigkeit faehigkeit = new Faehigkeit(Convert.ToInt32(row["FaehigkeitID"]),
                                                           row["Bezeichnung"].ToString(),
                                                           row["Auswirkung"].ToString());
                    result.Add(faehigkeit);
                }
               
            }
            return result;
        }

        public override string ToString()
        {
            return $"{ID}. {Bezeichnung}";
        }
    }
}