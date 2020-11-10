using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace infraestrutura.TextExport
{
	public interface FileTextInterface
	{


		FileTextInterface getData(dynamic datarows);

		public void Save(string destino);



	}
}
