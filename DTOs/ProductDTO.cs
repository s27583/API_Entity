using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Entity.DTOs
{
    public class ProductDTO
    {
    public string ProductName { get; set; }
    public double ProductWeight { get; set; }
    public double ProductWidth { get; set; }
    public double ProductHeight { get; set; }
    public double ProductDepth { get; set; }
    public List<int> ProductCategories { get; set; }
}
}