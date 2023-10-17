namespace CropsAppMVC.Models;

public partial class Crop
{
    public int Id { get; set; }

    public string CropName { get; set; }

    public int? CropYield { get; set; }

    public double? CropExpenses { get; set; }

    public double? CropIncome { get; set; }
}
