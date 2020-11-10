using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace infraestrutura.TextExport
{
    public class FileText: FileTextInterface
	{

		private dynamic DataRows;

		public string Descript { get; set; }
		public string FormatName { get; set; }
		public int Sequece { get; set; }
		public string Author { get; set; }
		public string Date { get; set; }
		
		public List<LayoutColumn> Rows { get; set; }

		

		public FileTextInterface GetData(dynamic datarows)
		{
		     DataRows = datarows;

			return this;


		}


		public void Export(string destino)
		{
			StringBuilder buid = new StringBuilder();
			//JProperty
			foreach (Newtonsoft.Json.Linq.JObject row in DataRows)
			{
			

				foreach (var item in row)
				{
					
					foreach (var column in Rows)
					{

                        if (item.Key == column.Name)//property name
                        {
							//string valorCampos = item.Value.ToString();
							//var Value = (string)datarow.GetType().GetProperty(column.Name).GetValue(datarow, null);
							var field  =column.Get(item.Value.ToString());

							buid.Append(field);
                        }





                    }

				}

				buid.AppendLine("");



			}



			

				
					
				 

			using (System.IO.StreamWriter file = new System.IO.StreamWriter(destino))
			{
				file.WriteLine(buid.ToString()); 
			}

		}
	}



}
