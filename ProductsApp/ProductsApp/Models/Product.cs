﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string name { get; set; }
		public string category { get; set; }
		public decimal Price { get; set; }
	}
}